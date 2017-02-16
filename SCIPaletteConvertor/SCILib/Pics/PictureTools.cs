using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace SCILib.Pics
{
    public enum PictureType : int
    {
        Unknown = 0x00000000,
        P56Patch = 0x00000101,
        P56Patch32 = 0x00008181,
        P56PatchOld = 0x00008081,
        P56PatchSCI1 = 0x2FE0081

    }
    public static class PictureTools
    {
        public static PictureType GetType(byte[] buffer)
        {
            PictureType type = PictureType.Unknown;
            int t = BitConverter.ToInt32(buffer, 0);
            //System.Windows.Forms.MessageBox.Show(t.ToString("X2"));
            foreach(PictureType pt in Enum.GetValues(typeof(PictureType)))
            {
                if ((int)pt == t)
                {
                    type = pt;
                    break;
                }
            }
            return type;
        }
        public static Picture Load(byte[] buffer, PictureType type)
        {
            switch (type)
            {
                case PictureType.P56PatchSCI1: return ReadP56Patch(buffer);
                case PictureType.P56Patch:
                case PictureType.P56Patch32:
                    return ReadP56Patch(buffer);
                case PictureType.P56PatchOld: return null;
                default: return null;
            }
        }
        static Picture ReadP56Patch(byte[] buffer)
        {
            Picture reply = new Picture();
            MemoryStream stream = new MemoryStream(buffer);
            BinaryReader reader = new BinaryReader(stream);

            int version = reader.ReadInt32();
            // should switch types here
            if (version == 0x2FE0081) // sci2 ?
            {
                // sci1 version is funky, after the first 4 bytes
                // we go directly into a sequential HEX count
                // 00 01 02 03 04 05 06 07 08 09 0a 0b etc
                // Looks like it may be a embedded font ?
                // its 256 bytes, no way it can be a palette
                byte[] font = reader.ReadBytes(256);
                // Now comes the palette
                Color[] _colors = new Color[256];
                reader.ReadInt32(); // 0's ?
                int firstColor = reader.ReadInt32();

                //int someSwitch = reader.ReadByte(); // this is a 1

                // set up first color
                for (int i = 0; i < firstColor; i++)
                {
                    _colors[i] = Color.Black;
                }

                for (int i = firstColor; i < _colors.Length; i++)
                {
                    //res r g b
                    int res = reader.ReadByte();
                    int r = reader.ReadByte();
                    int g = reader.ReadByte();
                    int b = reader.ReadByte();
                    
                    _colors[i] = Color.FromArgb(r, g, b);
                }
                reply.SCIPalette = new Palettes.Palette();
                reply.SCIPalette.FirstColor = 0;
                reply.SCIPalette.IsTripleColors = true;
                reply.SCIPalette.Colors = _colors;
                // postion 1288 seems to always be the position of this header.
                short cellHeader = reader.ReadInt16(); // this seems to always be 1278 (0xFE 0x04)
                




                // is the rest the picture ?
                byte[] pic = reader.ReadBytes(320 * 190);
                reply.Cells = new List<Cell>();
                Cell c = new Cell();
                c.Height = 190;
                c.Width = 320;
                c.CellPicture = CopyDataToBitmap(pic, reply.SCIPalette.Colors, (short)firstColor, 320, 190);
                reply.Cells.Add(c);
            }
            else if (version == 0x8081) // sci 1 ?
            {
            }
            else if (version == 0x8181) // this works, clean it up
            {
                short format = reader.ReadInt16();
                reader.ReadInt16(); // bs
                // new format
                short cellRecSize = reader.ReadInt16();
                bool isOldFormat = format == 0x38;
                if (!isOldFormat)
                {
                    if (cellRecSize != 0x2A) { throw new IndexOutOfRangeException("Cell Rec Size is not 0x2A !!"); }
                    // we go back to offset 4
                    reader.BaseStream.Seek(4, SeekOrigin.Begin);
                    reply.CellTableOffset = reader.ReadInt16();
                    reply.NumCells = reader.ReadByte();
                    reply.IsCompressed = Convert.ToBoolean(reader.ReadByte());
                    reply.CellRecSize = reader.ReadInt16();
                    reply.PaletteOffset = reader.ReadInt32();
                    reply.Width = reader.ReadInt16();
                    reply.Height = reader.ReadInt16();
                    // Ya all above is correct

                    // get the palette
                    reader.BaseStream.Seek(reply.PaletteOffset, SeekOrigin.Begin);
                    // byte palTag = reader.ReadByte();
                    int palLength = reader.ReadInt32();
                    byte[] pal = reader.ReadBytes(palLength);
                    Palettes.PalType type = Palettes.PaletteTools.GetType(pal);
                    short firstColor = 0;
                    bool isTripleColors = false;
                    reply.SCIPalette = new Palettes.Palette();
                    reply.SCIPalette.Colors = Palettes.PaletteTools.Load(pal, type, out firstColor, out isTripleColors);
                    reply.SCIPalette.FirstColor = firstColor;
                    reply.SCIPalette.IsTripleColors = isTripleColors;
                    // we want our cellheader now

                    reader.BaseStream.Seek(reply.CellTableOffset, SeekOrigin.Begin);
                    for (int i = 0; i < reply.NumCells; i++)
                    {
                        Cell c = new Cell();
                        c.Width = reader.ReadInt16();
                        c.Height = reader.ReadInt16();
                        c.XShift = reader.ReadInt16();
                        c.XShift = reader.ReadInt16();
                        c.TransparentColor = reader.ReadByte(); //1
                        c.Compression = reader.ReadByte(); // 2
                        c.Flags = reader.ReadInt16(); // 3 n 4
                        c.ImageAndPackSize = reader.ReadInt32();//
                        c.ImageSize = reader.ReadInt32();//
                        c.PaletteOffset = reader.ReadInt32();//
                        c.ImageOffset = reader.ReadInt32();//
                        c.PackedDataOffset = reader.ReadInt32();//
                        c.ScanLinesTableOffset = reader.ReadInt32();
                        c.ZDepth = reader.ReadInt16();
                        c.XPosition = reader.ReadInt16();
                        c.YPosition = reader.ReadInt16();
                        // I dunno what to do with compression atm so, TODO Compression.
                        reader.BaseStream.Seek(c.PackedDataOffset, SeekOrigin.Begin);
                        byte[] image = reader.ReadBytes(c.Width * c.Height);

                        c.CellPicture = CopyDataToBitmap(image, reply.SCIPalette.Colors, reply.SCIPalette.FirstColor, c.Width, c.Height);
                        reply.Cells.Add(c);
                    }
                }
                else
                {
                    if (cellRecSize != 0x38) { throw new IndexOutOfRangeException("Cell Rec Size is not 0x38 !!"); }

                }
            }
            reader.Close();
            return reply;
        }
        #region Bitmap Creation raw bmp data
        /// <summary>
        /// function CopyDataToBitmap
        /// Purpose: Given the pixel data return a bitmap of size [width,height],PixelFormat=8RGB 
        /// </summary>
        /// <param name="data">Byte array with pixel data</param>
        public static System.Drawing.Bitmap CopyDataToBitmap(byte[] data, Color[] colors, short firstColor, int width, int height)
        {
            //Here create the Bitmap to the known height, width and format
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(width, height, PixelFormat.Format8bppIndexed);

            ColorPalette p = bmp.Palette;
            for (int i = 0; i < firstColor; i++)
            {
                // all up to fist color are 0's
                p.Entries.SetValue(Color.FromArgb(0, 0,0), i);
            }
            for (int i = firstColor; i < colors.Length; i++)
            {
                p.Entries.SetValue(colors[i], i);
            }
            bmp.Palette = p;
            //bmp.Palette = colors;
            //Create a BitmapData and Lock all pixels to be written 
            BitmapData bmpData = bmp.LockBits(
                                 new Rectangle(0, 0, bmp.Width, bmp.Height),
                                 ImageLockMode.WriteOnly, bmp.PixelFormat);

            //Copy the data from the byte array into BitmapData.Scan0
            Marshal.Copy(data, 0, bmpData.Scan0, data.Length);


            //Unlock the pixels
            bmp.UnlockBits(bmpData);


            //Return the bitmap 
            return bmp;
        }
        #endregion
    }
}
