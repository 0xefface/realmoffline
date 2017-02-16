using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RoomParser
{
    public class Room
    {
        public uint RoomID;
        public string RoomName;
        public RoomBackground Background;
        public BlockedExits Blocked;
        public bool CastingAllowed;
        public List<RoomDecoration> Decorations;
        public Room() { this.Decorations = new List<RoomDecoration>(); }

        public Room FromBytes(byte[] buffer)
        {
            Room result = new Room();
            MemoryStream m = new MemoryStream(buffer);
            BinaryReader r = new BinaryReader(m);
            r.ReadBytes(17); // past bs
            short namelen = r.ReadInt16();
            result.RoomName = Encoding.ASCII.GetString(r.ReadBytes(namelen));
            //mainForm.WriteLine("2");
            r.ReadInt16(); // bs
            result.RoomID = r.ReadUInt32();
            ushort bckgrnd = r.ReadUInt16();


            RoomBackground b = RoomBackground.BeachLeft;
            foreach(RoomBackground rb in Enum.GetValues(typeof(RoomBackground)))
            {
                if(bckgrnd == (short)rb)
                {
                    b = rb;
                    break;
                }
            }
            result.Background = b;
            r.ReadByte(); //bs
            int block = r.ReadByte();
            BlockedExits be = BlockedExits.None;
            foreach (BlockedExits rb in Enum.GetValues(typeof(BlockedExits)))
            {
                if (block== (short)rb)
                {
                    be = rb;
                    break;
                }
            }
            result.Blocked = be;
            r.ReadByte(); // bs
            int allow = r.ReadByte();
            if (allow == 7)
                result.CastingAllowed = false;
            else result.CastingAllowed = true;
            // Ok now we have the decorations
            int totaldec = r.ReadByte();
            int current = 0;
            while (current != totaldec)
            {
                RoomDecoration d = RoomDecoration.FromCode(r.ReadUInt16(), r.ReadUInt16(), r.ReadUInt16(), r.ReadUInt16(), result.RoomID);
                result.Decorations.Add(d);
                current++;
            }
            
            return result;
        }
        public override string ToString()
        {
            return string.Format("Room {0}", this.RoomID);
        }
    }
}
