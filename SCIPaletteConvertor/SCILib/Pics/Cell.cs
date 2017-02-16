using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SCILib.Pics
{
    public class Cell
    {
        public short Width { get; set; }
        public short Height { get; set; }
        public short XShift { get; set; }
        public short YShift { get; set; }
        public byte TransparentColor { get; set; }
        public byte Compression { get; set; } // 0 = none 8A = rle
        public short Flags { get; set; }
        public int ImageAndPackSize { get; set; }
        public int ImageSize { get; set; }
        public int PaletteOffset { get; set; } // dont think we need this, already have palette
        public int ImageOffset { get; set; }
        public int PackedDataOffset { get; set; }
        public int ScanLinesTableOffset { get; set; }
        public short ZDepth { get; set; }
        public short XPosition { get; set; }
        public short YPosition { get; set; }
        public Image CellPicture { get; set; }
    }
}
