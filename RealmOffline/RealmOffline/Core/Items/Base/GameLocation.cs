using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core
{
    public class GameLocation
    {
        public uint RoomNumber;
        public ushort X;
        public ushort Y;
        public ushort Facing;

        public bool DoScaler = false;

        public GameLocation() { }

        public GameLocation(uint room, ushort x, ushort y, ushort facing , bool scale = false)
        {
            RoomNumber = room;
            X = x;
            Y = y;
            Facing = facing;
            DoScaler = scale;
        }
    }
}
