using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5210 : Room
  {
        public Room5210()
            : base(5210, "Mabon's Secrets")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 157, 59, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 182, 55, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 164, 68, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 24, 227, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 39, 234, 100, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 234, 23, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 459, 155, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 402, 171, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 36, 168, 65517, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 25, 168, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 115, 89, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2508, 10, 42, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 65533, 244, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 244, 216, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 635, 106, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 431, 87, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 38, 239, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 384, 239, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 472, 128, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 396, 144, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 630, 122, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 100, 221, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 36, 213, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 573, 221, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 665, 253, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 622, 177, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 494, 251, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 286, 185, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 456, 124, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 622, 128, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 573, 267, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 572, 273, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2701, 216, 180, 50, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2710, 206, 136, 50, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 297, 185, 65517, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(14, 363, 254, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 370, 237, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 384, 240, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 6, 230, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 213, 212, 0, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 261, 174, 100, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 97, 178, 100, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 125, 198, 100, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 219, 185, 100, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 65, 206, 100, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 89, 238, 100, 5210));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 385, 258, 0, 5210));
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

