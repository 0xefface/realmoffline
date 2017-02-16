using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace SCILib.Tools
{
    public class FileWriter
    {
        #region Fields
        private MemoryStream stream;
        private BinaryWriter writer;
        #endregion
        #region Constructors
        public FileWriter()
        {
            this.stream = new MemoryStream();
            this.writer = new BinaryWriter(this.stream);
        }
        #endregion
        #region INT's
        public void Write(bool value)
        {
            this.writer.Write(value);
        }
        public void Write(Int16 value)
        {
            this.writer.Write(value);
        }
        public void Write(Int32 value)
        {
            this.writer.Write(value);
        }
        public void Write(Int64 value)
        {
            this.writer.Write(value);
        }
        #endregion
        #region UINT's
        public void Write(UInt16 value)
        {
            this.writer.Write(value);
        }
        public void Write(UInt32 value)
        {
            this.writer.Write(value);
        }
        public void Write(UInt64 value)
        {
            this.writer.Write(value);
        }
        #endregion
        #region Byte(s)
        public void Write(byte value)
        {
            this.writer.Write(value);
        }
        public void Write(byte[] value)
        {
            this.writer.Write(value);
        }
        #endregion
        #region Strings
        public void WriteRawString(string value)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(value);
            this.writer.Write(buffer);
        }
        public void WriteString16(string value)
        {
            short len = (short)value.Length;
            this.writer.Write(len);
            byte[] buffer = Encoding.ASCII.GetBytes(value);
            this.writer.Write(buffer);
        }
        public void WriteString32(string value)
        {
            this.writer.Write(value.Length);
            byte[] buffer = Encoding.ASCII.GetBytes(value);
            this.writer.Write(buffer);
        }
        #endregion
        #region Color(s)
        public void WriteColor(Color color, bool quadColor = false)
        {
            // r g b
            if (quadColor)
            {
                this.writer.Write(color.A);
                this.writer.Write(color.R);
                this.writer.Write(color.G);
                this.writer.Write(color.B);
            }
            else
            {
                // Triple colors
                this.writer.Write(color.R);
                this.writer.Write(color.G);
                this.writer.Write(color.B);
                this.writer.Write((byte)0x00);// res
            }
        }
        public void WriteColors(Color[] color, bool quadColor = false)
        {
            // r g b
            if (quadColor)
            {
                for (int i = 0; i < color.Length; i++)
                {
                    this.writer.Write(color[i].A);
                    this.writer.Write(color[i].R);
                    this.writer.Write(color[i].G);
                    this.writer.Write(color[i].B);
                }
            }
            else
            {
                // Triple colors
                for (int i = 0; i < color.Length; i++)
                {
                    this.writer.Write(color[i].R);
                    this.writer.Write(color[i].G);
                    this.writer.Write(color[i].B);
                    this.writer.Write((byte)0x00);// res
                }
            }
        }
        #endregion
        #region Outputs
        /// <summary>
        /// Returns the written bytes to an array and closes the stream.
        /// </summary>
        /// <returns></returns>
        public byte[] ToArray()
        {
            this.writer.Flush();
            byte[] buffer = this.stream.ToArray();
            this.Close();
            return buffer;
        }
        public Stream ToStream()
        {
            return new MemoryStream(this.ToArray());
        }
        #endregion
        #region Close
        public void Close()
        {
            this.writer.Close();
        }
        #endregion
    }
}
