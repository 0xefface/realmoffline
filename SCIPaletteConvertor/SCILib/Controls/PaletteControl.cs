using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCILib.Palettes;
using System.IO;

namespace SCILib.Controls
{
    public partial class PaletteControl : UserControl
    {
        public delegate void PaletteLoaded(Palettes.PalType type, Color[] colors);
        public event PaletteLoaded OnPaletteLoaded;

        private PalType currentLoadedType;
        public PalType CurrentLoadedType
        {
            get { return currentLoadedType; }
            set { currentLoadedType = value; }
        }
        public int PaletteWidth
        {
            get { return paletteBox.Width; }
            set { paletteBox.Width = value; }
        }
        public int PaletteHeight
        {
            get { return paletteBox.Height; }
            set { paletteBox.Height = value; }
        }
        private int cellWidth;
        public int CellWidth
        {
            get { return cellWidth; }
            set { cellWidth = value; }
        }
        private int cellHeight;
        public int CellHeight
        {
            get { return cellHeight; }
            set { cellHeight = value; }
        }
        private Font cellFont;
        public Font CellFont
        {
            get
            {
                if (cellFont == null)
                    cellFont = new Font(DefaultFont.FontFamily, 6, FontStyle.Bold);
                return cellFont;
            }
            set { cellFont = value; }
        }
        public float FontSize
        {
            get { return this.CellFont.Size; }
            set { this.CellFont = new Font(this.CellFont.FontFamily, value, this.CellFont.Style); }
        }
        private Dictionary<Rectangle, Color> paletteRects;
        public Dictionary<Rectangle, Color> PaletteRects
        {
            get
            {
                if (paletteRects == null) paletteRects = new Dictionary<Rectangle, Color>();
                return paletteRects;
            }
            set { paletteRects = value; }
        }
        ToolTip t = new ToolTip(new System.ComponentModel.Container());
        private Rectangle LastToolTipReport;

        public PaletteControl()
        {
            InitializeComponent();
            this.contextMenuStrip1.Opening += new CancelEventHandler(contextMenuStrip1_Opening);
            PaletteRects = new Dictionary<Rectangle, Color>();
            this.paletteBox.MouseMove += new MouseEventHandler(paletteBox_MouseMove);
        }
        /// <summary>
        /// If we have no colors or palette rectangles mapped, then we cant export it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            this.contextMenuStrip1.Items[1].Enabled = this.PaletteRects.Count != 0;
        }

        private void paletteBox_MouseMove(object sender, MouseEventArgs e)
        {
            Point mpoint = paletteBox.PointToClient(Control.MousePosition);
            Rectangle mouse = new Rectangle(mpoint, new Size(2, 2));
            // Annoying way to do it, but it stops the flashing and works, so i am over it :D
            for (int i = 0; i < this.PaletteRects.Count; i++)
            {
                if (this.PaletteRects.ElementAt(i).Key.IntersectsWith(mouse))
                {
                    string palEntry = string.Format("Palette Entry({0})", i + 1);
                    if (this.LastToolTipReport == null)
                    {
                        this.LastToolTipReport = this.PaletteRects.ElementAt(i).Key;
                    }
                    else if (this.LastToolTipReport != this.PaletteRects.ElementAt(i).Key)
                    {
                        t.ToolTipTitle = palEntry;
                        t.SetToolTip(paletteBox, this.PaletteRects.ElementAt(i).Value.ToString());
                        this.LastToolTipReport = this.PaletteRects.ElementAt(i).Key;
                    }
                }
            }
        }
        public void ShowPalette(Color[] colors)
        {
            paletteRects.Clear();
            //int firstColor = 0;
            //colors = ConvertTo256Colors(colors, out firstColor);

           // MessageBox.Show(colors.Length.ToString());
            // drawing 16 squares, 16 times for total of 256 colors
            Bitmap p = new Bitmap(16 * this.CellWidth, 16 * this.CellHeight);
            this.PaletteWidth = p.Width;
            this.PaletteHeight = p.Height;
            Graphics g = Graphics.FromImage(p);
            int x = 0, y = 0;

            for (int i = 0; i < 256; i++)
            {
                SolidBrush b = null;
                // Try to get a color in the palette, if we error, then set us as black.
                try { b = new SolidBrush(colors[i]); }
                catch { b = new SolidBrush(Color.Black); }

                // Create a 25 x 25 rectangle at x, y
                Rectangle r = new Rectangle(x, y, this.CellWidth, this.CellHeight);

                // Draw a white border around it
                g.DrawRectangle(new Pen(new SolidBrush(Color.White)), r);

                // Fill it with our color
                g.FillRectangle(b, x, y, this.CellWidth - 2, this.CellHeight - 2);

                // Now draw the cell number inside the rect, with a font size of 6
                g.DrawString((i + 1).ToString(), this.CellFont, new SolidBrush(Color.Wheat), r);

                // Drop down to the next line of 16, if our next square goes over the width of our palette image.
                if (x + this.CellWidth >= p.Width)
                {
                    x = 0;
                    y += this.CellHeight;
                }
                else x += this.CellWidth;

                // Populate our rectangle dictionary, so we can check to see if the mouse interacts with the cell.
                paletteRects.Add(r, b.Color);
                if (this.OnPaletteLoaded != null) this.OnPaletteLoaded(this.CurrentLoadedType, this.PaletteRects.Values.ToArray());
            }
            this.paletteBox.Image = p;
            this.Refresh();
        }
        Color[] ConvertTo256Colors(Color[] input, out int firstColor)
        {
            List<Color> colorList = new List<Color>();
            firstColor = 256 - input.Length;

            for(int i = 0; i < firstColor;i++)
            {
                colorList.Add(Color.Black);
            }

            colorList.AddRange(input);

            return colorList.ToArray();
        }
        public override void Refresh()
        {
            this.Size = new Size(this.PaletteWidth, this.PaletteHeight);
            this.paletteBox.Dock = DockStyle.Fill;
            base.Refresh();
        }

        private void exportPaletteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.PaletteRects.Count == 0) return;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "pal";
            saveFileDialog.Filter = "Microsoft Palette File(*.pal)|*.pal|SCI Local Palette(Extracted from FotoSCIhop)|*.pal|SCI Global Palette(Extracted from Resource)|*.pal|SCI ROOT Palette(999.pal)|*.pal";
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.Title = "Exporting Palette, please choose a filename.";

            DialogResult r = saveFileDialog.ShowDialog();

            if (r == System.Windows.Forms.DialogResult.Cancel) return;
            try
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1: PaletteTools.SaveMicrosoftPalette(saveFileDialog.FileName, this.PaletteRects.Values.ToArray()); break;
                    case 2: PaletteTools.SaveLocalSCIPalette(saveFileDialog.FileName, this.PaletteRects.Values.ToArray()); break;
                    case 3: PaletteTools.SaveGlobalSCIPalette(saveFileDialog.FileName, this.PaletteRects.Values.ToArray()); break;
                    case 4: PaletteTools.SaveRootSCIPalette(saveFileDialog.FileName, this.PaletteRects.Values.ToArray()); break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop); }
        }

        private void importPaletteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Palette Files|*.pal";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select an SCI or Microsoft Palette.";

            DialogResult r = openFileDialog.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.Cancel) return;
            OpenPal(openFileDialog.FileName);

        }
         /// <summary>
        /// Opens and loads selected PAL file in the palBox
        /// </summary>
        private void OpenPal(string palFile)
        {
            if (File.Exists(palFile))
            {
                this.PaletteRects.Clear();
                try
                {
                    byte[] buffer = File.ReadAllBytes(palFile);
                    PalType type = PaletteTools.GetType(buffer);
                    if (type == PalType.Unknown)
                    {
                        MessageBox.Show(string.Format("Unknown Type {0}", BitConverter.ToInt32(buffer, 0).ToString("X2")));
                        return;
                    }
                    this.CurrentLoadedType = type;
                    ShowPalette(PaletteTools.Load(buffer, type));
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else MessageBox.Show("Unknown Error");
        }
    }
}
