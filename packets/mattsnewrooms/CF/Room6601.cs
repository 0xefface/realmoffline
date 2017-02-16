using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6601 : Room
  {
        public Room6601()
            : base(6601, "Wright Way Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2020, 161, 16, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 224, 2, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 321, 1, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 414, 2, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 487, 56, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 518, 17, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 625, 25, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 195, 153, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 436, 157, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2041, 49, 168, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 613, 168, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 55, 221, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2142, 12, 221, 50, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2146, 65503, 235, 55, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2150, 611, 250, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2151, 180, 203, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2143, 65505, 223, 10, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2146, 71, 224, 30, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2149, 0, 221, 65521, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 409, 296, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 416, 306, 55, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2133, 354, 301, 65, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2134, 443, 308, 55, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(34914, 487, 307, 55, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2131, 379, 300, 55, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2132, 284, 302, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2104, 150, 304, 0, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2544, 62, 174, 20, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 488, 197, 50, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 651, 204, 50, 6601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 246, 162, 20, 6601));
          this.AllowCasting = True;
          base.ApplyRoomLayout();
      }
// We do not know these values yet
      public override uint GetNextRoomByExit(RoomExit exit)
      {
          switch (exit)
          {
              case RoomExit.North: return 5043;
              case RoomExit.South: return 5043;
              case RoomExit.East: return 5043;
              case RoomExit.West: return 5043;
              default: return 5043;
           }
          }
      }
  }

