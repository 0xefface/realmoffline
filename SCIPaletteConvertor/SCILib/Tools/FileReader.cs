using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SCILib.Tools
{
    public class FileReader
    {
        #region Fields
        private MemoryStream stream;
        private BinaryReader reader;
        #endregion
        #region Constructors
        /// <summary>
        /// Opens a file for reading, file must exist, check before this call
        /// </summary>
        /// <param name="fileName"></param>
        public FileReader(string fileName) : this(File.ReadAllBytes(fileName)) { }
        /// <summary>
        /// Opens a byte array for reading
        /// </summary>
        /// <param name="fileData"></param>
        public FileReader(byte[] fileData) : this(new MemoryStream(fileData)) { }
        /// <summary>
        /// Opens a fileStream for reading.
        /// </summary>
        /// <param name="fileStream"></param>
        public FileReader(MemoryStream fileStream)
        {
            this.stream = fileStream;
            this.reader = new BinaryReader(this.stream);
        }
        #endregion
        #region Boolean
        public bool ReadBoolean()
        {
            return this.reader.ReadBoolean();
        }
        #endregion
        #region INT's
        public Int16 ReadInt16()
        {
            return this.reader.ReadInt16();
        }
        public Int32 ReadInt32()
        {
            return this.reader.ReadInt32();
        }
        public Int64 ReadInt64()
        {
            return this.reader.ReadInt64();
        }
        #endregion
        #region UINT's
        public UInt16 ReadUInt16()
        {
            return this.reader.ReadUInt16();
        }
        public UInt32 ReadUInt32()
        {
            return this.reader.ReadUInt32();
        }
        public UInt64 ReadUInt64()
        {
            return this.reader.ReadUInt64();
        }
        #endregion
        #region Byte(s)
        public byte ReadByte()
        {
            return this.reader.ReadByte();
        }
        public byte[] ReadBytes(int amount)
        {
            return this.reader.ReadBytes(amount);
        }
        #endregion
        #region Strings
        public string ReadRawString(int length)
        {
            byte[] buffer = reader.ReadBytes(length);
            return Encoding.ASCII.GetString(buffer);
        }
        /// <summary>
        /// Reads a short value from the buffer (2 bytes) then reads that length of data
        /// following those 2 bytes into a string.
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string ReadString16()
        {
            short length = this.reader.ReadInt16();
            byte[] buffer = reader.ReadBytes(length);
            return Encoding.ASCII.GetString(buffer);
        }
        /// <summary>
        /// Reads a int value from the buffer (4 bytes) then reads that length of data
        /// following those 4 bytes into a string.
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string ReadString32()
        {
            int length = this.reader.ReadInt32();
            byte[] buffer = reader.ReadBytes(length);
            return Encoding.ASCII.GetString(buffer);
        }
        #endregion
        #region Close
        public void Close()
        {
            this.reader.Close();
        }
        #endregion
    }
}
