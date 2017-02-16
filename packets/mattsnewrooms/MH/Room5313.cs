using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5313 : Room
  {
        public Room5313()
            : base(5313, "Outdoor Outfitters")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 157, 59, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 182, 55, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 164, 68, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 440, 49, 65471, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 582, 12, 65448, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 235, 22, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 461, 87, 65468, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 403, 95, 65460, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 36, 161, 65517, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 25, 161, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 269, 95, 65466, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 280, 85, 65437, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 115, 103, 33, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2508, 6, 40, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 515, 212, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 281, 221, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 412, 232, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 48, 210, 85, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 480, 242, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 42, 228, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 451, 253, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 13, 207, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 449, 68, 65452, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 581, 4, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 538, 289, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 12, 201, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2736, 413, 221, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(35503, 99, 115, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 498, 33, 65378, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 511, 218, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 498, 74, 65416, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 451, 12, 65418, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 399, 246, 0, 5313));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 555, 202, 0, 5313));
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

