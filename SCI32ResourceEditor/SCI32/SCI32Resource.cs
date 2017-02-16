using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace SCI32
{
    public class SCI32Resource
    {
        /// <summary>
        /// Gets the short id for theis resource.
        /// </summary>
        public ushort ID { get; private set; }
        /// <summary>
        /// Gets the offset at which this resource is contained in the packed file Ressci.*
        /// </summary>
        public uint Offset { get; private set; }
        /// <summary>
        /// Gets the SCI32 Resource type this is.
        /// </summary>
        public SCI32ResourceType ResourceType { get; private set; }
        /// <summary>
        /// Gets if this resource has its byte[] data held in this object.
        /// </summary>
        public bool HasFile { get; private set; }
        /// <summary>
        /// Gets the byte[] data of this resource.
        /// </summary>
        public byte[] FileData { get; private set; }
        /// <summary>
        /// Gets the compressed file length of this resource.
        /// </summary>
        public int CompressedLength { get; private set; }
        /// <summary>
        /// Gets the Uncompressed length of this resource.
        /// </summary>
        public int UnCompressedLength { get; private set; }
        /// <summary>
        /// Gets a value staing if we have the compressed and uncompressed lengths of this resource yet.
        /// </summary>
        public bool HasFileLengths { get; private set; }

        public string FileName
        {
            get { return string.Format("{0}{1}", this.ID, ExtentionFromResourceType(this.ResourceType)); }
        }

        [DllImport("LZDecompress.dll")]
        public static extern double Add(double a, double b);

        /// <summary>
        /// A SCI32 Packed Resource contained in a Ressci.* file, read into memory
        /// using the index file of Resmap.*.
        /// </summary>
        /// <param name="type">The SCI32 Type this resource is.</param>
        /// <param name="id">The Id of this resource.</param>
        /// <param name="atOffset">The offset in the packed file this resource begins at.</param>
        public SCI32Resource(SCI32ResourceType type, ushort id, uint atOffset)
        {
            this.ID = id;
            this.Offset = atOffset;
            this.ResourceType = type;
            this.HasFile = false;
            this.HasFileLengths = false;
        }
        /// <summary>
        /// Adds byte file data to this object.
        /// </summary>
        /// <param name="fileData"></param>
        public void AddFileData(byte[] fileData)
        {
            if (this.UnCompressedLength != this.CompressedLength)
            {
                // we need to uncompress
                //TODO: DECOMPRESS !!

                //CLZF lzf = new CLZF();
                //LZS.Net.LZS lzs = new LZS.Net.LZS();

                //byte[] data = new byte[this.UnCompressedLength];
                //lzs.Lzs_Unpack(fileData, this.UnCompressedLength); //SevenZip.Compression.LZMA.SevenZipHelper.Decompress(fileData);//new byte[this.UnCompressedLength];
                //lzf.lzf_decompress(fileData, fileData.Length, data, data.Length);
                this.FileData = fileData;//LZS.Net.LZS.DCL_Unpack(fileData, this.UnCompressedLength);
            }
            else
            this.FileData = fileData;
            this.HasFile = true;
        }
        /// <summary>
        /// Sets the compressed and uncompressed lengths of this resource.
        /// </summary>
        /// <param name="uncompressed"></param>
        /// <param name="compressed"></param>
        public void SetLengths(int compressed, int uncompressed)
        {
            this.UnCompressedLength = uncompressed;
            this.CompressedLength = compressed;
            this.HasFileLengths = true;
        }
        /// <summary>
        /// Gets the extention of the resource type, used for saving, returns .extention
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string ExtentionFromResourceType(SCI32ResourceType type)
        {
            if (type == SCI32ResourceType.None || type == SCI32ResourceType.EndResource) { return "invalid"; }
            return string.Format(".{0}", type.ToString().ToLower());
        }
        /// <summary>
        /// Gets the resource type by byte.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SCI32ResourceType GetResourceType(byte value)
        {
            SCI32ResourceType reply = SCI32ResourceType.None;
            foreach (SCI32ResourceType type in Enum.GetValues(typeof(SCI32ResourceType)))
            {
                if ((byte)type == value) { reply = type; }
            }
            return reply;
        }
    }
}
