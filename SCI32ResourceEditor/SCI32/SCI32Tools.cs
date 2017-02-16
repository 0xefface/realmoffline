using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCI32
{
    public static class SCI32Tools
    {
        #region Reader
        public class Reader : IDisposable
        {
            private MemoryStream fileStream { get; set; }
            private BinaryReader fileReader { get; set; }
            public Reader(byte[] file)
            {
                this.fileStream = new MemoryStream(file);
                this.fileReader = new BinaryReader(this.fileStream);
            }
            #region Normal Byte reading functions
            /// <summary>
            /// Reads a UInt16 from the stream and advances the stream 2 bytes
            /// </summary>
            /// <returns></returns>
            /// <exception cref="System.ArgumentException"></exception>
            /// <exception cref="System.ArgumentNullException"></exception>
            /// <exception cref="System.ArgumentOutOfRangeException"></exception>
            public UInt16 ReadUInt16()
            {
                return BitConverter.ToUInt16(this.fileReader.ReadBytes(2), 0);
            }
            /// <summary>
            /// Reads a UInt32 from the stream and advances the stream 4 bytes
            /// </summary>
            /// <returns></returns>
            /// <exception cref="System.ArgumentException"></exception>
            /// <exception cref="System.ArgumentNullException"></exception>
            /// <exception cref="System.ArgumentOutOfRangeException"></exception>
            public UInt32 ReadUInt32()
            {
                return BitConverter.ToUInt32(this.fileReader.ReadBytes(4), 0);
            }
            /// <summary>
            /// Reads a UInt64 from the stream and advances the stream 8 bytes
            /// </summary>
            /// <returns></returns>
            /// <exception cref="System.ArgumentException"></exception>
            /// <exception cref="System.ArgumentNullException"></exception>
            /// <exception cref="System.ArgumentOutOfRangeException"></exception>
            public UInt64 ReadUInt64()
            {
                return BitConverter.ToUInt64(this.fileReader.ReadBytes(8), 0);
            }
            /// <summary>
            /// Reads a Int16 from the stream and advances the stream 2 bytes
            /// </summary>
            /// <returns></returns>
            /// <exception cref="System.ArgumentException"></exception>
            /// <exception cref="System.ArgumentNullException"></exception>
            /// <exception cref="System.ArgumentOutOfRangeException"></exception>
            public Int16 ReadInt16()
            {
                return BitConverter.ToInt16(this.fileReader.ReadBytes(2), 0);
            }
            /// <summary>
            /// Reads a Int32 from the stream and advances the stream 4 bytes
            /// </summary>
            /// <returns></returns>
            /// <exception cref="System.ArgumentException"></exception>
            /// <exception cref="System.ArgumentNullException"></exception>
            /// <exception cref="System.ArgumentOutOfRangeException"></exception>
            public Int32 ReadInt32()
            {
                return BitConverter.ToInt32(this.fileReader.ReadBytes(4), 0);
            }
            /// <summary>
            /// Reads a Int64 from the stream and advances the stream 8 bytes
            /// </summary>
            /// <returns></returns>
            /// <exception cref="System.ArgumentException"></exception>
            /// <exception cref="System.ArgumentNullException"></exception>
            /// <exception cref="System.ArgumentOutOfRangeException"></exception>
            public Int64 ReadInt64()
            {
                return BitConverter.ToInt64(this.fileReader.ReadBytes(8), 0);
            }
            /// <summary>
            /// Reads a string from the stream and advances the stream the length of bytes read.
            /// </summary>
            /// <param name="length">Number of bytes to convert into a string.</param>
            /// <param name="encoder">The encoder used to convert bytes into a string.</param>
            /// <returns></returns>
            /// <exception cref="System.ArgumentException"></exception>
            /// <exception cref="System.ArgumentNullException"></exception>
            /// <exception cref="System.ArgumentOutOfRangeException"></exception>
            /// <exception cref="System.IO.IOException"></exception>
            /// <exception cref="System.ObjectDisposedException"></exception>
            /// <exception cref="System.Text.DecoderFallbackException"></exception>
            public string ReadString(int length, Encoding encoder)
            {
                byte[] buffer = fileReader.ReadBytes(length);
                return encoder.GetString(buffer);
            }
            /// <summary>
            /// Reads a single byte from the stream and advances the stream 1 byte
            /// </summary>
            /// <returns></returns>
            /// <exception cref="System.IO.EndOfStreamException"></exception>
            /// <exception cref="System.ObjectDisposedException"></exception>
            /// <exception cref="System.IO.IOException"></exception>
            public byte ReadByte()
            {
                return this.fileReader.ReadByte();
            }
            /// <summary>
            /// Reads a single byte from the stream and advances the stream 1 byte
            /// </summary>
            /// <returns></returns>
            /// <exception cref="System.ArgumentException"></exception>
            /// <exception cref="System.IO.IOException"></exception>
            /// <exception cref="System.ObjectDisposedException"></exception>
            /// <exception cref="System.ArgumentOutOfRangeException"></exception>
            public byte[] ReadBytes(int length)
            {
                return this.fileReader.ReadBytes(length);
            }
            public byte[] ReadUntilFF()
            {
                List<byte> reply = new List<byte>();
                try
                {
                    byte readByte = 0;
                    while ((readByte = this.ReadByte()) != 0xFF)
                    {
                        reply.Add(readByte);
                    }
                }
                catch { }
                return reply.ToArray();
            }
            /// <summary>
            /// Closes the reader.
            /// </summary>
            public void Close()
            {
                this.fileReader.Close();
            }
            /// <summary>
            /// Closes and then disposes of the reader.
            /// </summary>
            public void Dispose()
            {
                this.Close();
                this.fileStream.Dispose();
                this.fileReader.Dispose();
            }
            #endregion
            #region Custom Read Functions
            /// <summary>
            /// Gets the current position in the stream.
            /// </summary>
            public long CurrentPosition
            {
                get { return this.fileReader.BaseStream.Position; }
            }
            /// <summary>
            /// Gets the total length of the stream.
            /// </summary>
            public long Length
            {
                get { return this.fileReader.BaseStream.Length; }
            }
            /// <summary>
            /// Seeks to poisition in our data stream.
            /// </summary>
            /// <param name="position"></param>
            /// <param name="origin"></param>
            public void Seek(long position, SeekOrigin origin)
            {
                this.fileReader.BaseStream.Seek(position, origin);
            }
            #endregion
        }
        #endregion
        #region Writer
        public class Writer
        {
            private MemoryStream fileStream { get; set; }
            private BinaryWriter fileWriter { get; set; }
            private Encoding encoder { get; set; }
            /// <summary>
            /// Writes data to a stream
            /// </summary>
            /// <param name="enc"></param>
            public Writer(Encoding enc = null)
            {
                this.fileStream = new MemoryStream();
                this.fileWriter = new BinaryWriter(fileStream);
                if (enc == null)
                    this.encoder = Encoding.ASCII;
                else this.encoder = enc;
            }
            #region Normal Writing Functions
            /// <summary>
            /// Writes a UInt16 value to the stream
            /// </summary>
            /// <param name="uint16"></param>
            /// <exception cref="System.IO.IOException"></exception>
            /// <exception cref="System.ObjectDisposedException"></exception>
            public void Write(UInt16 uint16)
            {
                this.fileWriter.Write(uint16);
            }
            /// <summary>
            /// Writes a UInt32 value to the stream
            /// </summary>
            /// <param name="uint32"></param>
            /// <exception cref="System.IO.IOException"></exception>
            /// <exception cref="System.ObjectDisposedException"></exception>
            public void Write(UInt32 uint32)
            {
                this.fileWriter.Write(uint32);
            }
            /// <summary>
            /// Writes a UInt64 value to the stream
            /// </summary>
            /// <param name="uint64"></param>
            /// <exception cref="System.IO.IOException"></exception>
            /// <exception cref="System.ObjectDisposedException"></exception>
            public void Write(UInt64 uint64)
            {
                this.fileWriter.Write(uint64);
            }
            /// <summary>
            /// Writes a Int16 value to the stream
            /// </summary>
            /// <param name="int16"></param>
            /// <exception cref="System.IO.IOException"></exception>
            /// <exception cref="System.ObjectDisposedException"></exception>
            public void Write(Int16 int16)
            {
                this.fileWriter.Write(int16);
            }
            /// <summary>
            /// Writes a Int32 value to the stream
            /// </summary>
            /// <param name="int32"></param>
            /// <exception cref="System.IO.IOException"></exception>
            /// <exception cref="System.ObjectDisposedException"></exception>
            public void Write(Int32 int32)
            {
                this.fileWriter.Write(int32);
            }
            /// <summary>
            /// Writes a Int64 value to the stream
            /// </summary>
            /// <param name="int64"></param>
            /// <exception cref="System.IO.IOException"></exception>
            /// <exception cref="System.ObjectDisposedException"></exception>
            public void Write(Int64 int64)
            {
                this.fileWriter.Write(int64);
            }
            /// <summary>
            /// Writes a string value to the stream
            /// </summary>
            /// <param name="value"></param>
            /// <exception cref="System.ArgumentNullException"></exception>
            /// <exception cref="System.IO.IOException"></exception>
            /// <exception cref="System.ObjectDisposedException"></exception>
            /// <exception cref="System.Text.EncoderFallBackException"></exception>
            public void Write(string value)
            {
                byte[] buffer = encoder.GetBytes(value);
                this.fileWriter.Write(buffer);
            }
            /// <summary>
            /// Writes a byte value to the stream
            /// </summary>
            /// <param name="value"></param>
            /// <exception cref="System.IO.IOException"></exception>
            /// <exception cref="System.ObjectDisposedException"></exception>
            public void Write(byte value)
            {
                this.fileWriter.Write(value);
            }
            /// <summary>
            /// Writes an array of bytes value to the stream
            /// </summary>
            /// <param name="value"></param>
            /// <exception cref="System.IO.IOException"></exception>
            /// <exception cref="System.ObjectDisposedException"></exception>
            public void Write(byte[] value)
            {
                this.fileWriter.Write(value);
            }
            /// <summary>
            /// Closes this writer
            /// </summary>
            public void Close()
            {
                this.fileWriter.Close();
            }
            // Disposes of this writer and the underlaying stream.
            public void Dispose()
            {
                this.Close();
                this.fileStream.Dispose();
                this.fileWriter.Dispose();
            }
            /// <summary>
            /// Clears all buffers for the current writer and causes any buffered data to be written to the underlying stream.
            /// </summary>
            public void Flush()
            {
                this.fileWriter.Flush();
            }
            #endregion
            #region Custom Write Functions
            /// <summary>
            /// Writes the full stream to a byte array.
            /// </summary>
            /// <returns></returns>
            public byte[] ToArray()
            {
                // Flush
                this.Flush();
                return this.fileStream.ToArray();
            }
            /// <summary>
            /// Attempts to write the stream to a file, if it fails for any reason we throw a IOException
            /// </summary>
            /// <param name="fileName"></param>
            /// <exception cref="System.IO.IOException"></exception>
            public void SaveAsFile(string fileName)
            {
                try { File.WriteAllBytes(fileName, this.ToArray()); }
                catch (Exception ex) { throw new IOException(ex.Message); }
            }
            #endregion
        }
        #endregion
        public static class Messageproxy
        {
            public delegate void MessageEventHandler(object sender, MessageEventArgs e);
            public static event MessageEventHandler MessageRelay;
            public static void WriteLine(string message)
            {
                MessageRelay(new object(), new MessageEventArgs(message));
            }
        }
        public class MessageEventArgs : EventArgs
        {
            public string Message { get; private set; }
            public MessageEventArgs(string message)
            {
                this.Message = message;
            }
        }
    }
}
