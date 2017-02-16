using SCI32.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCI32
{
    public class SCI32ResourceDirectory
    {
        /// <summary>
        /// The SCI32ResourceType this directory contains, 1 type per directory
        /// </summary>
        public SCI32ResourceType Type { get; private set; }
        /// <summary>
        /// The offset in the Resmap.* file that contains the start of this directories resources.
        /// </summary>
        public uint Offset { get; private set; }
        /// <summary>
        /// The location of the packed file containing the resources.
        /// </summary>
        public string ResourceFileLocation { get; private set; }
        /// <summary>
        /// Gets the name of this resource file without the directory path.
        /// </summary>
        public string ResourceFileName { get; private set; }
        /// <summary>
        /// Holds the total amount of resources this directory has.
        /// </summary>
        public int Entries { get; set; }
        public int DataLength { get; set; }
        /// <summary>
        /// The collection of resources this directory contains.
        /// </summary>
        public SCI32ResourceCollection Resources { get; set; }

        /// <summary>
        /// A SCI32 Resource Directory
        /// </summary>
        /// <param name="res">the type of resource</param>
        /// <param name="offset">the offset that holds all resources of this type</param>
        /// <param name="fromResourceFile">the resource file location</param>
        public SCI32ResourceDirectory(byte res, uint offset, string fromResourceFile)
        {
            this.Type = SCI32Resource.GetResourceType(res);
            this.Offset = offset;
            this.Resources = new SCI32ResourceCollection();
            this.ResourceFileLocation = fromResourceFile;
            this.ResourceFileName = fromResourceFile.Split('\\').Last();
        }
        /// <summary>
        /// Adds a resource to our collection list.
        /// </summary>
        /// <param name="res"></param>
        public void AddResource(SCI32Resource res)
        {
            this.Resources.Add(res);
        }
        /// <summary>
        /// Gets the total number of resouces contained in this directory.
        /// </summary>
        /// <returns></returns>
        public int GetResourceCount()
        {
            return this.Resources.Count;
        }
        /// <summary>
        /// Trys to get a resource from our collection by index, returns a null resource if it fails.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="resource"></param>
        /// <returns></returns>
        public bool TryGetResourceByIndex(int index, out SCI32Resource resource)
        {
            resource = null;
            try
            {
                resource = this.Resources[index];
            }
            catch { }
            return resource != null;
        }

        public string GetDirectoryNameByType(SCI32ResourceType type)
        {
            switch (type)
            {
                case SCI32ResourceType.Aud: return "Audio";
                case SCI32ResourceType.Bmp: return "Bitmaps";
                case SCI32ResourceType.Cur: return "Cursors";
                case SCI32ResourceType.Fon: return "Fonts";
                case SCI32ResourceType.Hep: return "Heaps";
                case SCI32ResourceType.Map: return "Maps";
                case SCI32ResourceType.Msg: return "Messages";
                case SCI32ResourceType.P56: return "Pictures";
                case SCI32ResourceType.Pal: return "Palettes";
                case SCI32ResourceType.Pat: return "Patches";
                case SCI32ResourceType.Scr: return "Scripts";
                case SCI32ResourceType.Snd: return "Sounds";
                case SCI32ResourceType.Syn: return "Syncs";
                case SCI32ResourceType.V56: return "Views";
                case SCI32ResourceType.Voc: return "Vocabs";
                case SCI32ResourceType.Wav: return "Waves";
                default: return "Invalid";
            }
        }
    }
}
