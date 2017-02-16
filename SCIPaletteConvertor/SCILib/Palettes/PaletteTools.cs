using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using SCILib.Tools;

namespace SCILib.Palettes
{
    #region Known SCI Palette Formats
    /*
     * (2 bytes) short pal version (known (Hex:(0/0E/0B/8B))
     * Then depending on the version
     * 
     * Version 0 (Global contained inside Ressi.000 file types)
     * 
     * (7 bytes) not known, pass them by
     * 
     * (2 bytes) short TotalPaletteColors (Should be 256)
     * (2 bytes) short Not Known, pass them by.
     * (2 bytes) short remaining data in the palette minus these 2 bytes
     * (14 bytes) Not Known, pass them by
     * (2 bytes) short Total colors in the palette, the remaining are generally black or transparent.
     * (6 bytes) Unknown, pass them by.
     * This version of the pal file always has triple values for color, r,g,b and no alpha, 
     * Enrico uses 224, i use 225 for alpha, either way the remainder of this file contains 
     * the colors in 3 byte increments.
     * byte 0 = red, 1 = green, 2 = blue.
     * (totalcolors * 3 bytes) The palette
     * 
     * End of Version 00
     * 
     * Version 0E (Root type Palette's like 999.pal)
     * 
     * (11 bytes) not known, pass them by
     * (2 bytes) short remaining data in the palette minus these 2 bytes
     * (10 bytes) not known, pass them by
     * 
     * (2 bytes) short the first color section of the palette to contain
     * palette colors, if this value is 11, then the first 11 colors
     * will be black, and NOT contained in the byte count.
     * you will need to first fill in 11 color sections of your color table
     * before you begin to populate it with data from this palette,
     * otherwise your entire count will be under by this value.
     * 
     * (2 bytes) short Unknown, pass them by.
     * (2 bytes) short Total colors in the palette, the remaining are generally black or transparent.
     * (1 byte) byte ExFourColor, not sure what this is for, i never need to use it.
     * (1 byte) byte uses triple color or quad ? 0 = triple 1 = quad
     * (4 bytes) int Unknown, pass them by.
     * 
     * Now we begin our colors, if the triple color value above is 0, then we only use 3 bytes
     * like in version 0 above, if it is a 1, then we use 4 bytes, this will have a huge impact
     * on your palette colors if you mix these up.
     * 
     * if triplecolor value = 0
     * (totalcolors * 3) r, g, b
     * if triplecolor value = 1
     * (totalcolors * 4) flag, r, g, b
     * Ignore the flag, just build the colors with r, g , b
     * 
     * End of Version 0E
     * 
     * Version 8B / 0B I only have 8B examples, 0B is supposed to be the same, maybe ?
     * this version seems to always use a 4 color scheme
     * 
     * Now that i am going over it, looks the exact same except uses 4 byte colors, i fix later.
     * 
     * End of Version 8B
     * 
     */
    #endregion
    public enum PalType
    {
        Unknown,
        Bitmap,
        Microsoft,
        SCI,
        SCI1
    }
    public struct BMPRGBQuad
    {
        public byte blue;
        public byte green;
        public byte red;
        public byte res;
    }
    public struct SCIRGBQuad
    {
        public byte res;
        public byte red;
        public byte green;
        public byte blue;
    }
    public static class PaletteTools
    {
        public static PalType GetType(byte[] buffer)
        {
            if (Encoding.ASCII.GetString(buffer, 0, 4) == "RIFF") return PalType.Microsoft;
            else if (BitConverter.ToInt16(buffer, 0) == 0x0000
                || BitConverter.ToInt16(buffer, 0) == 0x000E
                || BitConverter.ToInt16(buffer, 0) == 0x000B
                || BitConverter.ToInt16(buffer, 0) == 0x008B) return PalType.SCI;
            else if (BitConverter.ToInt16(buffer, 0) == 19778) return PalType.Bitmap;
            else if (BitConverter.ToInt32(buffer, 0) == 0x3020100) return PalType.SCI1;
            else return PalType.Unknown;
        }
        public static Color[] Load(byte[] buffer, PalType type)
        {
            short first = 0;
            bool trip = false;
            switch (type)
            {
                case PalType.SCI: return LoadSCIPalette(buffer, out first, out trip);
                case PalType.Microsoft: return LoadMicrosoftPalette(buffer);
                case PalType.Bitmap: return LoadBMPPalette(buffer);
                case PalType.SCI1: return LoadSCIPalette(buffer, type, out first, out trip);
                default: return new Color[0];
            }
        }
        public static Color[] Load(byte[] buffer, PalType type, out short firstColor, out bool isTripleColors)
        {
            firstColor = 0;
            isTripleColors = true;
            switch (type)
            {
                case PalType.SCI: return LoadSCIPalette(buffer, out firstColor, out isTripleColors);
                case PalType.Microsoft: return LoadMicrosoftPalette(buffer);
                case PalType.Bitmap: return LoadBMPPalette(buffer);
                case PalType.SCI1: return LoadSCIPalette(buffer, type, out firstColor, out isTripleColors);
                default: return new Color[0];
            }
        }
        #region SCI Load Palette
        public static Color[] LoadSCIPalette(byte[] buffer, PalType type, out short firstColor, out bool isTripleColors)
        {
            FileReader r = new FileReader(buffer);
            List<Color> colors = new List<Color>();
            firstColor = 0;
            isTripleColors = true;

            switch (type)
            {
                case PalType.SCI1:
                    {
                        // Starts with a 256 byte block, hex values counting from 0 to 255
                        r.ReadBytes(256);
                        r.ReadInt32(); //bs
                        firstColor = (short)r.ReadInt32(); // is this really a int everywhere ?

                        for (int i = 0; i < firstColor; i++) colors.Add(Color.Black);
                        //colors[11] = fi
                        for (int i = firstColor; i < 256; i++)
                        {
                            // this is a flagbit
                            // 0 	The entry is used
                            // 4 	Another color has been inexactly mapped to this one 
                            int flag = r.ReadByte();
                            // rgb colors
                            int red = r.ReadByte();
                            int green = r.ReadByte();
                            int blue = r.ReadByte();

                            colors.Add(Color.FromArgb(red, green, blue));
                        }

                    }
                    break;
                default: break;
            }
            r.Close();
            return colors.ToArray();
        }
        public static Color[] LoadSCIPalette(byte[] buffer, out short firstColor, out bool isTripleColors)
        {
            MemoryStream s = new MemoryStream(buffer);
            BinaryReader r = new BinaryReader(s);
            // need to switch on this header type, for now we gonna ignore all but what i working on
            short headerType = r.ReadInt16();
            firstColor = 0;
            isTripleColors = false;
            switch (headerType)
            {
                #region Works for version 0000 (Global)
                case 0x0000:
                    {
                        // pal files contained in SCI Ressci.00*
                        r.ReadBytes(7); // not sure always seems blank
                        int totalPalColors = r.ReadInt16();
                        r.ReadInt16(); // bs ?
                        int remainingData = r.ReadInt16();
                        // Good up to this point so far.
                        // 14 bytes till next short ?
                        r.ReadBytes(14);
                        short totalColors = (short)(r.ReadInt16());
                        r.ReadBytes(6); // 6 bytes ? wierd
                        Color[] colors = new Color[totalColors];
                        firstColor = 0;
                        isTripleColors = true;
                        for (int i = 0; i < colors.Length; i++)
                        {
                            // no flagbit
                            int red = r.ReadByte();
                            int green = r.ReadByte();
                            int blue = r.ReadByte();

                            colors[i] = Color.FromArgb(224, red, green, blue);
                        }
                        r.Close();
                        return colors;
                    }
                #endregion
                #region Works for version 000E (999.pal types Root Palettes)
                case 0x000E:
                    {
                        r.BaseStream.Seek(0, SeekOrigin.Begin);
                        short palID = r.ReadInt16();
                        r.ReadBytes(11);
                        short datalen = r.ReadInt16();
                        r.ReadBytes(10);
                        firstColor = r.ReadInt16();
                        short unk1 = r.ReadInt16();
                        short numColors = r.ReadInt16();
                        byte exfourColor = r.ReadByte();
                        isTripleColors = Convert.ToBoolean(r.ReadByte());
                        r.ReadBytes(4);
                        Color[] colors = new Color[numColors+ firstColor];
                        for (int i = 0; i < firstColor; i++) colors[i] = Color.Black;
                        for (int i = firstColor; i < colors.Length ; i++)
                        {
                            if (!isTripleColors) r.ReadByte(); // if we aint triple colors, then read another byte
                            // no flagbit
                            int red = r.ReadByte();
                            int green = r.ReadByte();
                            int blue = r.ReadByte();

                            colors[i] = Color.FromArgb(red, green, blue);
                        }

                        r.Close();
                        return colors;
                    }
                #endregion
                #region Works for version 008B (Extracted Local Palettes)
                case 0x008B:
                    {
                        short palID = r.ReadInt16();
                        r.ReadBytes(11);
                        short datalen = r.ReadInt16();
                        r.ReadBytes(10);
                        firstColor = r.ReadInt16();
                        short unk1 = r.ReadInt16();
                        short numColors = r.ReadInt16();
                        byte exfourColor = r.ReadByte();
                        isTripleColors = Convert.ToBoolean(r.ReadByte());
                        r.ReadBytes(4);
                        Color[] colors = new Color[numColors];
                        for (int i = 0; i < firstColor; i++) colors[i] = Color.Black;
                        //colors[11] = fi
                        for (int i = firstColor; i < colors.Length; i++)
                        {
                            // this is a flagbit
                            // 0 	The entry is used
                            // 4 	Another color has been inexactly mapped to this one 
                            int flag =r.ReadByte();
                            // rgb colors
                            int red = r.ReadByte();
                            int green = r.ReadByte();
                            int blue = r.ReadByte();
                            
                            colors[i] = Color.FromArgb(red, green, blue);
                        }
                        r.Close();
                        return colors;
                    }
                #endregion
                default: throw new NotImplementedException(string.Format("No support for header {0}", headerType.ToString("X2")));
            }
        }
        #endregion
        #region Microsoft Load Palette
        public static Color[] LoadMicrosoftPalette(byte[] buffer)
        {
            List<Color> colors = new List<Color>();
            MemoryStream stream = new MemoryStream(buffer);
            using (BinaryReader reader = new BinaryReader(stream))
            {
                // RIFF Header
                string riff = Encoding.ASCII.GetString(reader.ReadBytes(4)); // RIFF
                int dataSize = reader.ReadInt32();
                string type = Encoding.ASCII.GetString(reader.ReadBytes(4)); // PAL 

                // Data Chunk
                string chunkType = Encoding.ASCII.GetString(reader.ReadBytes(4)); // data
                int chunkSize = reader.ReadInt32();
                short palVersion = reader.ReadInt16();
                short palEntries = reader.ReadInt16();

                for (int i = 0; i < palEntries; i++)
                {
                    byte red = reader.ReadByte();
                    byte green = reader.ReadByte();
                    byte blue = reader.ReadByte();
                    byte flags = reader.ReadByte();
                    colors.Add(Color.FromArgb(red, green, blue));
                }
                return colors.ToArray();
            }
        }
        public static void SaveMicrosoftPalette(string filename, Color[] colors)
        {
          int length = 4 + 4 + 4 + 4 + 2 + 2 + colors.Length * 4;

            FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.Write,
                FileShare.None);
            using (BinaryWriter bw = new BinaryWriter(stream))
            {
                // RIFF Header
                bw.Write(Encoding.ASCII.GetBytes("RIFF"));
                bw.Write(length);
                bw.Write(Encoding.ASCII.GetBytes("PAL "));

                // Data Chunk
                bw.Write(Encoding.ASCII.GetBytes("data"));
                bw.Write(colors.Length * 4 + 4);
                bw.Write((short)0x0300);
                bw.Write((short)colors.Length);

                for (int i = 0; i < colors.Length; i++)
                {
                    bw.Write((byte)colors[i].R);
                    bw.Write((byte)colors[i].G);
                    bw.Write((byte)colors[i].B);
                    bw.Write((byte)0);
                }
            }
        }
        #endregion
        #region Get Palette from Bitmap files
        public static Color[] LoadBMPPalette(byte[] buffer)
        {
            List<Color> colors = new List<Color>();
            MemoryStream s = new MemoryStream(buffer);
            BinaryReader read = new BinaryReader(s);
            // go past bmp header
            read.ReadBytes(14);
            // go into dib header to et the number of colors the bmp palette has.
            int dibLen = read.ReadInt32();
            if (dibLen != 40) throw new ArgumentOutOfRangeException(string.Format("Invalid value {0} for Dib header size.", dibLen));

            int bmpWidth = read.ReadInt32();
            int bmpHeight = read.ReadInt32();
            short colorPlanes = read.ReadInt16(); // must be 1
            // the number of bits per pixel, which is the color depth of the image. 
            // Typical values are 1, 4, 8, 16, 24 and 32
            short bits = read.ReadInt16();

            /*
             * 0 	BI_RGB 	none 	Most common
             * 1 	BI_RLE8 	RLE 8-bit/pixel 	Can be used only with 8-bit/pixel bitmaps
             * 2 	BI_RLE4 	RLE 4-bit/pixel 	Can be used only with 4-bit/pixel bitmaps
             * 3 	BI_BITFIELDS 	OS22XBITMAPHEADER: Huffman 1D 	BITMAPV2INFOHEADER: RGB bit field masks,
             * BITMAPV3INFOHEADER+: RGBA
             * 4 	BI_JPEG 	OS22XBITMAPHEADER: RLE-24 	BITMAPV4INFOHEADER+: JPEG image for printing[10]
             * 5 	BI_PNG 		BITMAPV4INFOHEADER+: PNG image for printing[10]
             * 6 	BI_ALPHABITFIELDS 	RGBA bit field masks 	only Windows CE 5.0 with .NET 4.0 or later
             * 11 	BI_CMYK 	none 	only Windows Metafile CMYK[4]
             * 12 	BI_CMYKRLE8 	RLE-8 	only Windows Metafile CMYK
             * 13 	BI_CMYKTLE4 	RLE-4 	only Windows Metafile CMYK
             */
            int compressionMethod = read.ReadInt32();
            int imageSize = read.ReadInt32(); // dummy size of 0 can be given for BI_RGB bitmaps
            int horiResolution = read.ReadInt32();
            int vertResolution = read.ReadInt32();
            int numPaletteColors = read.ReadInt32(); // 0 defaults to 2n
            // the number of important colors used, or 0 when every color is important; generally ignored
            int impColors = read.ReadInt32();
            // we always 4 bits
            // so now do we jump 3 bytes or not ?
            //read.ReadBytes(12);
            for (int i = 0; i < numPaletteColors; i++)
            {
                int b = read.ReadByte();
                int g = read.ReadByte();
                int r = read.ReadByte();
                int a = read.ReadByte();
                colors.Add(Color.FromArgb(a, r, g, b));
            }

           // System.Windows.Forms.MessageBox.Show(string.Format("{0} colors.", numPaletteColors));
            read.Close();
            return colors.ToArray();
        }

        #endregion
        #region SCI
        #region Global
        public static void SaveGlobalSCIPalette(string fileName, Color[] colors)
        {
            MemoryStream stream = new MemoryStream();
            using (BinaryWriter w = new BinaryWriter(stream))
            {
                w.Write((short)0x00);
                w.Write(new byte[7]);
                w.Write((short)256);
                w.Write((short)0x00);
                // wee need a data len here missing short !!! of all following
                short dataLen = (short)((colors.Length * 3) + 22);
                w.Write(dataLen);
                w.Write(new byte[14]);
                w.Write((short)colors.Length);
                w.Write((byte)0x01); //exfourColor
                w.Write((byte)0x01); //tripleColor yes we are triple color
                w.Write((int)0x00);
                for (int i = 0; i < colors.Length; i++)
                {
                    w.Write(colors[i].R);
                    w.Write(colors[i].G);
                    w.Write(colors[i].B);
                }
                w.Flush();
                // save
                File.WriteAllBytes(fileName ,stream.ToArray());
            }
        }
        #endregion
        #region Local
        public static void SaveLocalSCIPalette(string fileName, Color[] colors)
        {
            MemoryStream stream = new MemoryStream();
            using (BinaryWriter w = new BinaryWriter(stream))
            {
                // This is sloppy, but seems to work, i wonder 
                // what will happen when the first color is really black ?
                // Havent seen any examples where it is.
                short firstColor = 0;
                for (short i = 0; i < colors.Length; i++)
                {
                    if (colors[i] == Color.Black) firstColor++;
                }

                w.Write((short)0x8B);
                w.Write((byte)0x0E);
                for (int i = 0; i < 9; i++)
                    w.Write((byte)0x20);
                w.Write((short)0x01);
                w.Write((byte)0x00);
                // short datalen all after this !!!!
                short dataLen = (short)((colors.Length * 4) + 22);
                w.Write(dataLen);
                w.Write(new byte[10]);
                w.Write(firstColor);
                w.Write((short)0x00);
                w.Write((short)colors.Length);
                w.Write((byte)0x01); //exFourColor
                w.Write((byte)0x00);// triple color, we are not triple.
                w.Write(new byte[4]);
                // now write the colors
                for (int i = 0; i < colors.Length; i++)
                {
                    w.Write((byte)0x00); // flag
                    w.Write(colors[i].R);
                    w.Write(colors[i].G);
                    w.Write(colors[i].B);
                    
                }
                w.Flush();
                // save
                File.WriteAllBytes(fileName, stream.ToArray());
            }
        }
        #endregion
        #region ROOT
        public static void SaveRootSCIPalette(string fileName, Color[] colors)
        {
            MemoryStream stream = new MemoryStream();
            using (BinaryWriter w = new BinaryWriter(stream))
            {
                // This is sloppy, but seems to work, i wonder 
                // what will happen when the first color is really black ?
                // Havent seen any examples where it is.
                short firstColor = 0;
                for (short i = 0; i < colors.Length; i++)
                {
                    if (colors[i] == Color.Black) firstColor++;
                }
                w.Write((short)0x0E);
                // 11 bytes of stuff i have no idea, may as well
                // use the only example i got.
                w.Write(new byte[] { 0x1C, 0x00, 0x00, 0xFF, 0x00, 0xA6, 0x0F, 0xA6, 0x01, 0x00, 0x00});
                // short for rest of dta ADD !!!!! TODO !!
                short dataLen = (short)((colors.Length * 3) + 22);
                w.Write(dataLen);
                // 10 bytes of stuff i have no idea, may as well
                // use the only example i got.
                w.Write(new byte[] { 0x00, 0x40, 0x8B, 0x9D, 0xCC, 0x24, 0x03, 0x47, 0x00, 0x00 });
                w.Write((short)firstColor);
                w.Write((short)0x00);
                w.Write((short)(colors.Length - firstColor));
                w.Write((byte)0x01); // exFourColor
                w.Write((byte)0x01); // we are triple color
                w.Write((int)0x00);
                for (int i = firstColor; i < colors.Length; i++)
                {
                    // no flag
                    w.Write(colors[i].R);
                    w.Write(colors[i].G);
                    w.Write(colors[i].B);
                }
                w.Flush();
                // save
                File.WriteAllBytes(fileName, stream.ToArray());

            }
        }
        #endregion
        #endregion
        #region Convertors
        public static SCIRGBQuad ConvertBMPQuadToSCIQuad(BMPRGBQuad bmpQuad)
        {
            // we reverse
            SCIRGBQuad result = new SCIRGBQuad();
            result.res = bmpQuad.res;
            result.red = bmpQuad.red;
            result.green = bmpQuad.green;
            result.blue = bmpQuad.blue;
            return result;
        }
        public static BMPRGBQuad ConvertSCIQuadToBMPQuad(SCIRGBQuad sciQuad)
        {
            // we reverse
            BMPRGBQuad result = new BMPRGBQuad();
            result.res = sciQuad.res;
            result.red = sciQuad.red;
            result.green = sciQuad.green;
            result.blue = sciQuad.blue;
            return result;
        }
        #endregion
    }
}
