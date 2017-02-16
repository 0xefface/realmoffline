using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5209 : Room
  {
        public Room5209()
            : base(5209, "Mystic Magic")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.Down;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 247, 26, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 337, 57, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 437, 59, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 632, 157, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 109, 317, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 11, 200, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 129, 330, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 545, 214, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 365, 161, 100, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 657, 175, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 282, 146, 100, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(7904, 165, 197, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2957, 297, 210, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2957, 533, 257, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2601, 492, 181, 100, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 24, 221, 108, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 22, 204, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 545, 6, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2650, 604, 213, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2643, 485, 155, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 65528, 187, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 33, 334, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 487, 234, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2650, 542, 225, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 611, 246, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2643, 485, 224, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 527, 174, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 200, 23, 65386, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 331, 59, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 474, 224, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 474, 156, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 199, 113, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 8, 163, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 199, 173, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 533, 245, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 376, 226, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 686, 223, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2957, 492, 245, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 422, 234, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 242, 202, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 34, 183, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 198, 194, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(32828, 641, 221, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 422, 191, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 245, 159, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 80, 216, 105, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2596, 234, 140, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2596, 411, 172, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2643, 590, 210, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 600, 7, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 366, 66, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 47, 214, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 27, 222, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 193, 6, 65376, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2958, 131, 335, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 535, 62, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 608, 62, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 380, 66, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 296, 192, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 296, 130, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 377, 210, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 377, 142, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2623, 485, 90, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2624, 555, 79, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 489, 87, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 408, 73, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 552, 192, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(2643, 590, 146, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 312, 215, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 519, 255, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 480, 255, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 569, 240, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 632, 237, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 263, 211, 0, 5209));
          this.AddRoomDecoration(RoomDecoration.FromCode(7904, 375, 232, 0, 5209));
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

