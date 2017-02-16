using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5413 : Room
  {
        public Room5413()
            : base(5413, "The White Rabbit")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 379, 62, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 465, 47, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 414, 65, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 514, 13, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 662, 128, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 334, 121, 41, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2508, 232, 41, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 167, 212, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 637, 245, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 166, 223, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 607, 249, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 311, 238, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 341, 232, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 145, 202, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 545, 208, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 119, 212, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 407, 62, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2753, 306, 119, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2752, 304, 169, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 599, 168, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 366, 183, 19, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 245, 178, 18, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 597, 171, 8, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 563, 221, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(35559, 274, 135, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 329, 259, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 11, 4, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 14, 33, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 65528, 78, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(32793, 36, 128, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(25, 70, 82, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 331, 225, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 332, 171, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2757, 331, 76, 65491, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2751, 301, 223, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2541, 355, 182, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 245, 165, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 151, 172, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 146, 121, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 149, 49, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(35377, 282, 43, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 63, 131, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 142, 206, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 262, 209, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 314, 217, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 561, 200, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 627, 229, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 587, 225, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 504, 221, 0, 5413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2797, 239, 154, 0, 5413));
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

