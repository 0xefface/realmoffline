
using nQuant;
/// To Do
/// 
using SCILib.Palettes;
using SCILib.Pics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace SCIPaletteConverter
{
    /// <summary>
    /// 
    /// </summary>
    
    
    public partial class mainForm : Form
    {

        public static mainForm Instance;
        public Color[] LoadedColors;
        private Dictionary<Rectangle, Color> palette;
        private string defaultTxt;
        private static Point formLocation = Properties.Settings.Default.formLocation;
        private static Size formSize = Properties.Settings.Default.formSize;
        private static string colorValue;
        private static string block;
        private static string palFile = null;


        // Constructor
        public mainForm()
        {
            InitializeComponent();
            LoadedColors = new Color[0];
            palette = new Dictionary<Rectangle, Color>();
            Instance = this;
            this.paletteControl1.OnPaletteLoaded += new SCILib.Controls.PaletteControl.PaletteLoaded(paletteControl1_OnPaletteLoaded);
        }


        #region Form Events =================================================================================

        /// <summary>
        /// Loads saved settings and prepares form
        /// </summary>
        private void Form_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.formLocation.IsEmpty)
                this.Location = formLocation;
            else
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            if (!Properties.Settings.Default.formSize.IsEmpty)
                this.Size = formSize;

            defaultTxt = this.Text;

            palInfoLbl.Text = null;
            if (picBox.Image == null)
            {
                saveAsBtn.Enabled = false;
                saveAsFileMenu.Enabled = false;
            }
            ((Control)picBox).AllowDrop = true;
            picBox.DragEnter += PicBox_DragEnter;
            picBox.MouseLeave += PicBox_MouseLeave;
        }

        private void PicBox_MouseLeave(object sender, EventArgs e)
        {
            if(picBox.Cursor == Cursors.Hand) picBox.Cursor = Cursors.No;
        }

        private void PicBox_DragEnter(object sender, DragEventArgs e)
        {
            string fileName = string.Empty;

            bool get = GetFilename(out fileName, e);

            if (get)
            {
                picBox.Cursor = Cursors.Hand;
                Image img = Image.FromFile(fileName);
                MessageBox.Show(string.Format("{0} Colors.", img.Palette.Entries.Count()));
                picBox.Image = img;
              //  MessageBox.Show(fileName);
            }
        }

        protected bool GetFilename(out string filename, DragEventArgs e)
        {
            bool ret = false;
            filename = String.Empty;

            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array data = ((IDataObject)e.Data).GetData("FileName") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        filename = ((string[])data)[0];
                        string ext = Path.GetExtension(filename).ToLower();
                        if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp"))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Saves settings and prompts if closing without saving changes
        /// </summary>
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            formLocation = this.Location;
            Properties.Settings.Default.formLocation = formLocation;

            formSize = this.Size;
            Properties.Settings.Default.formSize = formSize;

            Properties.Settings.Default.Save();
        }
        /// <summary>
        /// Lets us know when our palette control loads a palette
        /// </summary>
        /// <param name="type"></param>
        /// <param name="colors"></param>
        private void paletteControl1_OnPaletteLoaded(PalType type, Color[] colors)
        {
            palInfoLbl.Text = string.Format("Palette type - {0}, {1} Colors", type, colors.Length);
            // Do we have a picture ? if not load us in the big screen too
            // hm i dunno if i wanna do that, but maybe
        }
        #endregion Form Events


        #region Menubar =====================================================================================

        /// <summary>
        /// Opens Browse dialog to select palette file
        /// </summary>
        private void openFileMenu_Click(object sender, EventArgs e)
        {
            Open();
        }


        /// <summary>
        /// To do, method to save changes to current file
        /// </summary>
        private void saveFileMenu_Click(object sender, EventArgs e)
        {
          
        }


        /// <summary>
        /// Save palette as Microsoft pal format
        ///     To do, change to save as new MS pal file
        /// </summary>
        private void saveAsMicrosoftPalFileMenu_Click(object sender, EventArgs e)
        {
            SaveMicrosoftPal();
        }


        /// <summary>
        /// Save palette as SCI format
        ///     To do, change to save as new SCI pal file
        /// </summary>
        private void saveAsSCIPalFileMenu_Click(object sender, EventArgs e)
        {
            SaveSCIPal();
        }


        /// <summary>
        /// Closes form
        /// </summary>
        private void exitFileMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Menubar


        #region Toolbar =====================================================================================

        /// <summary>
        /// Opens Browse dialog to select palette file
        /// </summary>
        private void openBtn_Click(object sender, EventArgs e)
        {
            Open();
        }


        /// <summary>
        /// Save palette as Microsoft pal format
        ///     To do, change to save as new MS pal file
        /// </summary>
        private void saveAsMicrosoftPalBtn_Click(object sender, EventArgs e)
        {
            SaveMicrosoftPal();
        }


        /// <summary>
        /// Save palette as SCI format
        ///     To do, change to save as new SCI pal file
        /// </summary>
        private void saveAsSCIPalBtn_Click(object sender, EventArgs e)
        {
            SaveSCIPal();
        }

        #endregion Toolbar


        #region palBox Events Group =========================================================================

        /// <summary>
        /// Handles the mouse click event in the palBox
        /// </summary>
        private void palBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Were is da mousie ?
            Rectangle mouse = new Rectangle(e.Location, new Size(2, 2));
            for (int i = 0; i < palette.Count; i++)
            {
                if (palette.ElementAt(i).Key.Contains(mouse))
                {
                    statusMessage.Text = string.Format("Cell {0} contains {1}", i + 1, palette.ElementAt(i).Value);

                    if (e.Button == MouseButtons.Right)
                    {
                        colorValue = palette.ElementAt(i).Value.ToString();
                        block = i.ToString();
                        
                        // Invoke context menu here as binding the context menu to the palBox
                        // control overrides all other methods.
                        palCntxtMenu.Show(picBox, e.Location);
                    }
                }
            }
        }


        /// <summary>
        /// Copies the ARGB color value of selected color to clipboard
        /// </summary>
        private void copyColorValueCntxMenu_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(colorValue))
            {
                colorValue = colorValue.Replace("Color [", "");
                colorValue = colorValue.Replace("]", "");

                // Copy string to clipboard
                if (!String.IsNullOrEmpty(colorValue))
                    try
                    {
                        Clipboard.SetText(colorValue);
                        MessageBox.Show("Value of color " + block + " copied to clipboard");
                    }
                    catch { }
            }
        }

        #endregion palBox Events Group


        #region Extra Functions =============================================================================

        private void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            

            //openFileDialog.DefaultExt = "p56";
            openFileDialog.Filter = "All SCI Types|*.pal;*.p56|All Image Types|*.bmp;*.emf;*.gif;*.ico;*.jpg;*.png;*.tif;*.wmf|P56|*.p56|PAL|*.pal";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select an SCI or Microsoft Palette.";

            DialogResult r = openFileDialog.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.Cancel) return;

            string ext = Path.GetExtension(openFileDialog.FileName).ToUpper();
            if (File.Exists(openFileDialog.FileName))
            {
                palFile = openFileDialog.FileName;
                if (ext == ".PAL")
                    OpenPal();
                else if (ext == ".P56")
                    OpenP56();
                else if (ext == ".BMP" || ext == ".EMF" || ext == ".GIF" || ext == ".ICO" || ext == ".JPG" || ext == ".PNG" || ext == ".TIF" || ext == ".WMF")
                    OpenImage(openFileDialog.FileName);
                else
                {
                    MessageBox.Show("No SCI graphic resource selected", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }


        /// <summary>
        /// Opens and loads selected PAL file in the palBox
        /// </summary>
        private void OpenPal()
        {
            if (File.Exists(palFile))
            {
                palette.Clear();
                try
                {
                    byte[] buffer = File.ReadAllBytes(palFile);
                    PalType type = PaletteTools.GetType(buffer);
                    if (type == PalType.Unknown)
                    {
                        MessageBox.Show(string.Format("Unknown Type {0}", BitConverter.ToInt32(buffer, 0).ToString("X2")));
                        return;
                    }
                    LoadedColors = PaletteTools.Load(buffer, type);
                    palInfoLbl.Text = string.Format("Palette type - {0}, {1} Colors", type, LoadedColors.Length);
                    this.Text = defaultTxt + " - " + palFile;
                    paletteControl1.ShowPalette(LoadedColors);
                    ShowPalette(LoadedColors);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else MessageBox.Show("Unknown Error");

            // Enable save
            if (picBox.Image != null)
            {
                saveAsBtn.Enabled = true;
                saveAsFileMenu.Enabled = true;
            }
            else
            {
                saveAsBtn.Enabled = false;
                saveAsFileMenu.Enabled = false;
            }
        }


        /// <summary>
        /// Displays an array of Colors (256 total even if they are null), as a palette.
        /// </summary>
        /// <param name="colors"></param>
        void ShowPalette(Color[] colors)
        {
            // drawing 16 squares, 16 times for total of 256 colors
            // 25 x 25 with a font size of 6 for cell numbers is because i am old and half blind.
            Bitmap p = new Bitmap(16 * 25, 16 * 25);
            picBox.Width = p.Width;
            picBox.Height = p.Height;
            Graphics g = Graphics.FromImage(p);
            int x = 0, y = 0;

            for (int i = 0; i < 256; i++)
            {
                SolidBrush b = null;
                // Try to get a color in the palette, if we error, then set us as black.
                try { b = new SolidBrush(colors[i]); }
                catch { b = new SolidBrush(Color.Black); }

                // Create a 25 x 25 rectangle at x, y
                Rectangle r = new Rectangle(x, y, 25, 25);

                // Draw a white border around it
                g.DrawRectangle(new Pen(new SolidBrush(Color.White)), r); 

                // Fill it with our color
                g.FillRectangle(b, x, y, 23, 23);

                // Now draw the cell number inside the rect, with a font size of 6
                g.DrawString((i + 1).ToString(), new Font(DefaultFont.FontFamily, 6,
                    FontStyle.Bold), new SolidBrush(Color.Wheat), r);

                // Drop down to the next line of 16, if our next square goes over the width of our palette image.
                if (x + 25 == p.Width)
                {
                    x = 0;
                    y += 25;
                }
                else x += 25;

                // Populate our rectangle dictionary, so we can check to see if the mouse interacts with the cell.
                palette.Add(r, b.Color);
            }
            g.Flush();
            // Set the image.
            picBox.Image = p;
        }


        /// <summary>
        /// Opens and loads palette from selected P56 file in the palBox
        /// </summary>
        private void OpenP56()
        {
            if (File.Exists(palFile))
            {
                palette.Clear();

                try
                {
                    byte[] buffer = File.ReadAllBytes(palFile);
                    PictureType type = PictureTools.GetType(buffer);
                    Picture p = PictureTools.Load(buffer, type);
                    this.Text = defaultTxt + " " + palFile;

                    if (p != null)
                    {
                        if (p.SCIPalette != null)
                        {
                            if (p.SCIPalette.Colors != null)
                            {
                                paletteControl1.ShowPalette(p.SCIPalette.Colors);
                                this.LoadedColors = p.SCIPalette.Colors;
                                palInfoLbl.Text = string.Format("Palette type - {0}, {1} Colors", type, LoadedColors.Length);
                            }
                            else MessageBox.Show("Colors is null");
                        }
                        else MessageBox.Show("Palette is null");
                    }
                    else MessageBox.Show("P is null");

                    if (p.Cells != null)
                    {
                        if(p.Cells.Count != 0 && p.Cells[0] != null)
                        {
                            if(p.Cells[0].CellPicture != null)
                            {
                                ResetPictureBox(p.Cells[0].CellPicture);
                            }
                        }
                    }
                    
                }
                catch (Exception ex) { MessageBox.Show(string.Format("{0} : {1}.", ex.Message, ex.StackTrace)); }
            }
            else MessageBox.Show("Unknown Error");

            // Enable save
            if (picBox.Image != null)
            {
                saveAsBtn.Enabled = true;
                saveAsFileMenu.Enabled = true;
            }
            else
            {
                saveAsBtn.Enabled = false;
                saveAsFileMenu.Enabled = false;
            }
        }


        void OpenImage(string fileName)
        {
            // This needs fixed, returns a 224 color palette no matter what
            Image img = null;
            palette.Clear();


            try
            {
                img = Image.FromFile(fileName);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Unable to Load Image !!", MessageBoxButtons.OK, MessageBoxIcon.Stop); }

            // CLONE DOES NOT WORK, NEED TO 

            // Any image we work with in this version must be 8 bit format, only way we can get a palette
            Bitmap bmp = null;

            if (img.PixelFormat != PixelFormat.Format8bppIndexed) bmp = Quantize(img);
            else bmp = new Bitmap(img);

            // ok we want the highest quality we can get, we are going to try swapping to 8pp to get the palette, then back to 16 to display
         //   Bitmap formattedImage16Bits = bmp.Clone(new Rectangle(0, 0, img.Width, img.Height), PixelFormat.Format16bppArgb1555);

           // Bitmap formattedImage8Bit = bmp.Clone(new Rectangle(0, 0, img.Width, img.Height), PixelFormat.Format8bppIndexed);

            // get the color table

            Color[] colors = bmp.Palette.Entries;


            paletteControl1.ShowPalette(colors);
            this.LoadedColors = colors;
            palInfoLbl.Text = string.Format("Palette type - {0}, {1} Colors", "Bitmap", LoadedColors.Length);


            picBox.Image = bmp;//Bitmap.FromStream(bmpStream);

            // Enable save
            if (picBox.Image != null)
            {
                saveBtn.Enabled = true;
                saveFileMenu.Enabled = true;
                saveAsFileMenu.Enabled = true;
            }
            else
            {
                saveBtn.Enabled = false;
                saveFileMenu.Enabled = false;
                saveAsFileMenu.Enabled = false;
            }
            this.Text = defaultTxt + " " + fileName;
            this.picBox.Width = img.Width;
            this.picBox.Height = img.Height;
        }
        public static Bitmap Quantize(Image img)
        {
            WuQuantizer q = new WuQuantizer();
            using (var bitmap = new Bitmap(img))
            {
                using (var quantized = q.QuantizeImage(bitmap))
                {
                    using (MemoryStream _stream = new MemoryStream())
                    {
                        quantized.Save(_stream, ImageFormat.Bmp);
                        return new Bitmap(_stream);
                    }
                }
            }
        }
        public static byte[] BitmapToBytes(Bitmap bitmap)
        {

            BitmapData bmpdata = null;
            try
            {
                bmpdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
                int numbytes = bmpdata.Stride * bitmap.Height;
                byte[] bytedata = new byte[numbytes];
                IntPtr ptr = bmpdata.Scan0;

                Marshal.Copy(ptr, bytedata, 0, numbytes);

                return bytedata;
            }
            finally
            {
                if (bmpdata != null)
                    bitmap.UnlockBits(bmpdata);
            }

        }
        #region Save

        /// <summary>
        /// Saves loaded palette as a Microsoft palette
        /// </summary>
        private void SaveMicrosoftPal()
        {
            if (LoadedColors.Length == 0) return;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "pal";
            saveFileDialog.Filter = "Microsoft Palette File(*.pal)|*.pal";
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.Title = "Save as Microsoft Palette file.";

            DialogResult r = saveFileDialog.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.Cancel) return;

            try
            {
                PaletteTools.SaveMicrosoftPalette(saveFileDialog.FileName, LoadedColors);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        /// <summary>
        /// Saves loaded palette as an SCI palette
        /// </summary>
        private void SaveSCIPal()
        {
            if (LoadedColors.Length == 0) return;
            // we have a few types of sci pal, sucks

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            /*
            saveFileDialog.DefaultExt = "pal";
            saveFileDialog.Filter = "Microsoft Palette File(*.pal)|*.pal";
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.Title = "Save as Microsoft Palette file.";
            */

            // We have 3 different types of SCI *.pal, this lets you choose which to save as.
            saveFileDialog.DefaultExt = "pal";
            saveFileDialog.Filter = "SCI Local Palette(Extracted from FotoSCIhop)|*.pal|SCI Global Palette(Extracted from Resource)|*.pal|SCI ROOT Palette(999.pal)|*.pal";
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.Title = "Save Palette as SCI.";
            
            DialogResult r = saveFileDialog.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.Cancel) return;

            switch (saveFileDialog.FilterIndex)
            {
                case 1:
                    {
                        try
                        {
                            PaletteTools.SaveLocalSCIPalette(saveFileDialog.FileName, LoadedColors);
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                    break;
                case 2:
                    {
                        try
                        {
                            PaletteTools.SaveGlobalSCIPalette(saveFileDialog.FileName, LoadedColors);
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                    break;
                case 3: try
                    {
                        PaletteTools.SaveRootSCIPalette(saveFileDialog.FileName, LoadedColors);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); } break;
            }
        }

        #endregion

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        void ResetPictureBox(Image img)
        {
            this.picBox.Image = img;
            this.picBox.Width = img.Width;
            this.picBox.Height = img.Height;
            this.picBox.BackgroundImageLayout = ImageLayout.Stretch;
        }
        #endregion Extra Functions

        private void viewMenuZoom1x_Click(object sender, EventArgs e)
        {
            //if (viewMenuZoom1x.Checked == true)
            //{
            //    viewMenuZoom1x.Checked = true;
            //    viewMenuZoom2x.Checked = false;
            //}
            //else if (viewMenuZoom1x.Checked == false)
            //{
            //    viewMenuZoom1x.Checked = false;
            //    viewMenuZoom2x.Checked = true;
            //}
        }


        private void viewMenuZoom1x_CheckStateChanged(object sender, EventArgs e)
        {
            if (viewMenuZoom1x.Checked == true)
                viewMenuZoom2x.Checked = false;
            else if (viewMenuZoom1x.Checked == false)
                viewMenuZoom2x.Checked = true;
        }


        private void viewMenuZoom2x_Click(object sender, EventArgs e)
        {
            //if (viewMenuZoom2x.Checked == true)
            //{
            //    viewMenuZoom2x.Checked = true;
            //    viewMenuZoom1x.Checked = false;
            //}
            //else if (viewMenuZoom2x.Checked == false)
            //    viewMenuZoom1x.Checked = true;
        }


        private void viewMenuZoom2x_CheckStateChanged(object sender, EventArgs e)
        {
            if (viewMenuZoom2x.Checked == true)
                viewMenuZoom1x.Checked = false;
            else if (viewMenuZoom2x.Checked == false)
                viewMenuZoom1x.Checked = true;
        }

        #region Saves Image as all types System.Drawing supports
        private void toolStripSaveImage_Click(object sender, EventArgs e)
        {
            // this will save as any filetype Image supports

            Image img = picBox.Image;

            if (img == null) return;

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Bmp|*.bmp|Metafile|*.emf|GIF|*.gif|Icon|*.ico|Jpeg|*.jpg|Png|*.png|Tif|*.tif|Wmf|*.wmf";
            save.AddExtension = true;

            DialogResult result = save.ShowDialog();


            if (result == DialogResult.OK)
            {
                switch (save.FileName.Split('.').Last().ToLower())
                {
                    #region Switches
                    case "bmp":
                        {
                            try
                            {
                                img.Save(save.FileName, ImageFormat.Bmp);
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message, string.Format("Unable to save file {0} !!!", save.FileName), MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                        }
                        break;
                    case "emf":
                        {
                            try
                            {
                                img.Save(save.FileName, ImageFormat.Emf);
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message, string.Format("Unable to save file {0} !!!", save.FileName), MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                        }
                        break;
                    case "gif":
                        {
                            try
                            {
                                img.Save(save.FileName, ImageFormat.Gif);
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message, string.Format("Unable to save file {0} !!!", save.FileName), MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                        }
                        break;
                    case "ico":
                        {
                            try
                            {
                                img.Save(save.FileName, ImageFormat.Icon);
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message, string.Format("Unable to save file {0} !!!", save.FileName), MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                        }
                        break;
                    case "jpeg":
                    case "jpg":
                        {
                            try
                            {
                                img.Save(save.FileName, ImageFormat.Jpeg);
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message, string.Format("Unable to save file {0} !!!", save.FileName), MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                        }
                        break;
                    case "png":
                        {
                            try
                            {
                                img.Save(save.FileName, ImageFormat.Png);
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message, string.Format("Unable to save file {0} !!!", save.FileName), MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                        }
                        break;
                    case "tiff":
                    case "tif":
                        {
                            try
                            {
                                img.Save(save.FileName, ImageFormat.Tiff);
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message, string.Format("Unable to save file {0} !!!", save.FileName), MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                        }
                        break;
                    case "wmf":
                        {
                            try
                            {
                                img.Save(save.FileName, ImageFormat.Wmf);
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message, string.Format("Unable to save file {0} !!!", save.FileName), MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                        }
                        break;
                    default: MessageBox.Show(string.Format("Unable to save as file type {0}!!", save.FileName.Split('.').Last())); break;
                        #endregion
                }
            }
            #endregion

        }
    }
}
