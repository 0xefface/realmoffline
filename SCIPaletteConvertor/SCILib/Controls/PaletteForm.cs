using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SCILib.Palettes;

namespace SCILib.Controls
{
    public partial class PaletteForm : Form
    {
        public PaletteForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "pal";
            openFileDialog.Filter = "Palette Files (SCI or Microsfot RIFF)|*.pal";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select a SCI or Microsoft Palette.";

            DialogResult r = openFileDialog.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.Cancel) return;

            if (File.Exists(openFileDialog.FileName))
            {
                try
                {
                    byte[] buffer = File.ReadAllBytes(openFileDialog.FileName);
                    PalType type = PaletteTools.GetType(buffer);
                    paletteControl1.CellWidth = 25;
                    paletteControl1.CellHeight = 25;
                    paletteControl1.FontSize = 4;
                    paletteControl1.ShowPalette(PaletteTools.Load(buffer, type));
                    paletteControl1.Refresh();
                }
                catch (Exception ex) { MessageBox.Show(string.Format("{0} : {1}", ex.Message, ex.StackTrace)); }
            }
            else MessageBox.Show("Unknown Error");
        }
    }
}
