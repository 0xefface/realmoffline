using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCI32.Collections
{
    public class SCI32ResourceDirectoryCollection : SCI32Collection<SCI32ResourceDirectory>
    {
        private SCI32Tools.Reader resmapReader { get; set; }
        private SCI32Tools.Reader ressciReader { get; set; }
        public string ResourceDirectoryPath { get; private set; }
        public string ResmapFileName { get; private set; }
        public string RessciFileName { get; private set; }
        public bool StopProcessing { get; set; }
        public void ProcessResmap(string resmap)
        {
            /* Ok we actually need 2 files here, this resmap file, which would be named
             * Something like RESMAP.000, and the file it respresents RESSCI.000
             * we need the later because it contains the actual data, resmap is just a index file.
             */
            // Checks
            if (!File.Exists(resmap)) { throw new IOException(string.Format("File {0} does not exist.", resmap)); }
            try
            {
                // First get the path, because both files should be there
                this.ResourceDirectoryPath = Path.GetDirectoryName(resmap);
                this.ResmapFileName = resmap.Split('\\').Last().ToLower();
                string extention = this.ResmapFileName.Split('.').Last().ToLower();
                this.RessciFileName = string.Format("ressci.{0}", extention).ToLower();
            }
            catch (Exception ex) { throw new IOException(string.Format("<Unable to process files {0} and {1}> Error was: {2}", resmap, Path.Combine(this.ResourceDirectoryPath,this.RessciFileName), ex.Message)); }

            string ressciFileLocation = Path.Combine(this.ResourceDirectoryPath, this.RessciFileName);

            if (!File.Exists(Path.Combine(this.ResourceDirectoryPath, this.RessciFileName))) { throw new IOException(string.Format("Ressci File {0} does not exist.", ressciFileLocation)); }
            if (!this.ResmapFileName.StartsWith("resmap")) { throw new IOException(string.Format("We must read the resmap index file first. Invalid File {0}", this.ResmapFileName)); }
            byte[] resmapBytes = null;
            byte[] ressciBytes = null;
            // Load the files first.
            // Resmap
            try 
            { 
                resmapBytes = File.ReadAllBytes(resmap);
                this.resmapReader = new SCI32Tools.Reader(resmapBytes);
            }
            catch (Exception ex) { throw new IOException(string.Format("<Unable to read Resmap file {0}> Error was: {1}", resmap, ex.Message)); }

            //ressci
            try
            {
                ressciBytes = File.ReadAllBytes(ressciFileLocation);
                this.ressciReader = new SCI32Tools.Reader(ressciBytes);
            }
            catch (Exception ex) { throw new IOException(string.Format("<Unable to read Ressci file {0}> Error was: {1}", ressciFileLocation, ex.Message)); }

            // Both files are found and loaded into our readers, continue.
            // RESMAP first
            try
            {
                byte[] dirs = this.resmapReader.ReadUntilFF();
                SCI32Tools.Reader r = new SCI32Tools.Reader(dirs);
                while(r.CurrentPosition != r.Length)
                {
                    if (StopProcessing) { break; }
                    this.Add(new SCI32ResourceDirectory(r.ReadByte(), r.ReadUInt16(), this.ResmapFileName));
                }
                
            }
            catch (Exception ex) { throw new IOException(string.Format("Unable to build resource directories from {0}, this is a fatal error, cannot continue. Error was {1}", this.ResmapFileName, ex.Message)); }
            
            // we have a good dir load.
            this.PopulateResmapResourceData(resmapBytes.Length);
            //this.Populate(resmapBytes.Length);
            /* Resources are populate now from resmap, need to move onto ressci
             * Each resource begins with 1 byte for type so we can match it with ours
             * to make sure we are leading the correct resource, then we have 2 bytes for the id
             * both to be checked again to make sure we have the right resource, then we have 4
             * bytes for the compressed length and 4 for uncompressed.
             * Final step if we get passed this we have all data loaded
             * compressed or uncompressed.
             */
            this.PopulateResmapResources();
        }
        private void Populate(int lengthOfFile)
        {
            List<uint> offsets = new List<uint>();
            for(int i=0;i<this.Count;i++)
            {
                offsets.Add(this[i].Offset);
            }
            int processed = 0;
            while (processed != offsets.Count)
            {
                for (int i = 0; i < this.Count; i++)
                {
                    SCI32ResourceDirectory dir = this[i];
                    if (offsets.Count <= i + 1)
                    {
                        dir.DataLength = (int)(offsets[i + 1] - offsets[i]);
                        dir.Entries = dir.DataLength / 6;
                    }
                    else
                    {
                        dir.DataLength = (int)(lengthOfFile - offsets[i]);
                        dir.Entries = dir.DataLength / 6;
                    }
                    processed++;
                }
            }
        }
        private void PopulateResmapResources()
        {
            // we read our ressci file, in a nested loop
            for (int i = 0; i < this.Count; i++)
            {
                SCI32ResourceDirectory sci32Dir = this[i];
                for (int j = 0; j < this[i].Resources.Count; j++)
                {
                    SCI32Resource res = sci32Dir.Resources[j];
                    this.ressciReader.Seek(res.Offset, SeekOrigin.Begin);
                    // Compare resources
                    SCI32ResourceType type = SCI32Resource.GetResourceType(this.ressciReader.ReadByte());
                    //if(type != res.ResourceType)
                    //{ throw new IOException(string.Format("Type Mismatch {0} for {1} should be {2}.", type, res.ID, res.ResourceType)); }
                    ushort id = this.ressciReader.ReadUInt16();
                    if (res.ID != id)
                    { throw new IOException(string.Format("ID {0} Mismatch for {1}.", id, res.ID)); }
                    try
                    {
                        // Ok we passed the compare get our lengths
                        res.SetLengths(this.ressciReader.ReadInt32(), this.ressciReader.ReadInt32());
                        // Are we compressed ?
                        bool compressed = res.UnCompressedLength != res.CompressedLength;
                        if (compressed)
                            res.AddFileData(this.ressciReader.ReadBytes(res.CompressedLength));
                        else res.AddFileData(this.ressciReader.ReadBytes(res.UnCompressedLength));
                    }
                    catch (Exception ex) { throw new IOException(string.Format("Unable to load filedata from {0} into resource. Error was {1}", this.RessciFileName, ex.Message)); }
                }
            }
        }

        // Fix this
        private void PopulateResmapResourceData(int lengthOfFile)
        {
            // We have our dir's once we begin at the offset of the first dir, then we load the amount of entires we know
            // then move onto the next
            // get our first directory, start there work our way on
            /*
            SCI32ResourceDirectory dir = this[0];
            this.resmapReader.Seek(dir.Offset, SeekOrigin.Begin);
            // start reading
            while (this.resmapReader.CurrentPosition != this.resmapReader.Length )
            {
                SCI32ResourceType type = SCI32Resource.GetResourceType(this.resmapReader.ReadByte());
                if (TryGetDirectoryByType(type, out dir))
                {
                    try
                    {
                        dir.AddResource(new SCI32Resource(type, this.resmapReader.ReadUInt16(), this.resmapReader.ReadUInt32()));
                    }
                    catch { SCI32Tools.Messageproxy.WriteLine("Erored"); }
                }
            }

            */
             
            // bad
            
            // need to generate the lengths of each data block here, its the prior offset - the next one
            long currentOffset = 0;
            long nextOffset = 0;
            int length = 0;
            try
            {
                for (int i = 0; i < this.Count; i++)
                {
                    currentOffset = this[i].Offset;
                    if (this.Count >= i + 2)
                    {
                        nextOffset = this[i + 1].Offset;
                        length = (int)(nextOffset - currentOffset);
                        this[i].DataLength = length;
                        this[i].Entries = length / 6;
                    }
                    else
                    {
                        // EOF
                        nextOffset = (int)resmapReader.Length;
                        length = (int)(nextOffset - currentOffset);
                        this[i].DataLength = length;
                        this[i].Entries = length / 6;
                    }
                }
            }
            catch (Exception ex) { throw new IOException(string.Format("Unable to parse Resource Directories from file {0}. Error was {1}", this.ResmapFileName, ex.Message)); }
           /*
            List<uint> offsets = new List<uint>();
            for (int i = 0; i < this.Count; i++)
            {
                offsets.Add(this[i].Offset);
            }
            
            int processed = 0;
            while (processed != offsets.Count)
            {
                for (int i = 0; i < this.Count; i++)
                {
                    SCI32ResourceDirectory dir = this[i];
                    
                        if (offsets.Count < (i + 1))
                        {
                            dir.DataLength = (int)(offsets[(i + 1)] - offsets[i]);
                            dir.Entries = dir.DataLength / 6;
                        }
                        else
                        {
                            dir.DataLength = (int)(lengthOfFile - offsets[i]);
                            dir.Entries = dir.DataLength / 6;
                        }
                        processed++;
                }
            } */
            // Second Stage
            byte[] resourceData = null;
            SCI32Tools.Reader r = null;
            for (int i = 0; i < this.Count; i++)
            {
                SCI32ResourceDirectory sci32Dir = this[i];
                try
                {
                    this.resmapReader.Seek(sci32Dir.Offset, SeekOrigin.Begin);
                    resourceData = this.resmapReader.ReadBytes(sci32Dir.DataLength);
                    r = new SCI32Tools.Reader(resourceData);
                    while (r.CurrentPosition != r.Length)
                    {
                        if (StopProcessing) { break; }
                        SCI32Resource res = new SCI32Resource(sci32Dir.Type, r.ReadUInt16(), r.ReadUInt32());
                        sci32Dir.AddResource(res);
                    }
                }
                catch (Exception ex) { throw new IOException(string.Format("Unable to parse Resources from file {0}. Error was {1}", this.ResmapFileName, ex.Message)); }
            }
             
        }
        public bool TryGetDirectoryByType(SCI32ResourceType type, out SCI32ResourceDirectory dir)
        {
            dir = null;
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].Type == type) { dir = this[i]; }
            }

            return dir != null;
        }
        public bool TryGetResourceByFilename(string fileName, out SCI32Resource resource)
        {
            resource = null;
            try
            {
                for (int i = 0; i < this.Count; i++)
                {
                    SCI32ResourceDirectory dir = this[i];
                    if (dir == null) { return false; }
                    for (int j = 0; j < dir.Resources.Count; j++)
                    {
                        SCI32Resource res = dir.Resources[j];
                        if (res == null) { return false; }
                        if (res.FileName.ToLower() == fileName.ToLower()) { resource = dir.Resources[j]; }
                    }
                }
            }
            catch { }
            return resource != null;
        }
    }
}
