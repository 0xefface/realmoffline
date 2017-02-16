using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SCILib.Palettes;

namespace SCILib.Pics
{
    public class Picture
    {
        public short CellTableOffset { get; set; }
        public byte NumCells { get; set; }
        public bool IsCompressed { get; set; }
        public short CellRecSize { get; set; }
        public int PaletteOffset { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }
        public Palette SCIPalette { get; set; }
        public List<Cell> Cells { get; set; }
        public Picture()
        {
            this.Cells = new List<Cell>();
        }
    }
}
