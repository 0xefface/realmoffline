using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5601 : Room
  {
        public Room5601()
            : base(5601, "Wright Way")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 157, 59, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 182, 55, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 164, 68, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 440, 49, 65471, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 582, 12, 65448, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 200, 15, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 426, 80, 65468, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 372, 85, 65460, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 36, 161, 65517, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 25, 161, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 264, 92, 65466, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 275, 82, 65437, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 115, 103, 33, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2508, 6, 40, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 161, 152, 65486, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 243, 211, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 412, 232, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 48, 210, 85, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 442, 235, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 42, 228, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 87, 236, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 13, 207, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 407, 68, 65452, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 581, 4, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 538, 289, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 12, 201, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2736, 381, 200, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(35503, 99, 115, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 522, 40, 65378, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 528, 211, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 498, 74, 65416, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 451, 12, 65418, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 351, 246, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 509, 220, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 485, 55, 0, 5601));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 468, 31, 0, 5601));
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

