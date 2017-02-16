using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5402 : Room
  {
        public Room5402()
            : base(5402, "Good Fortune Inn")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2511, 275, 50, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2664, 236, 77, 65473, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2665, 321, 154, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2524, 412, 78, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2646, 332, 153, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 237, 148, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 268, 154, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2630, 337, 85, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 516, 251, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 558, 98, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 456, 248, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 187, 149, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 405, 188, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2510, 217, 227, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2510, 304, 242, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 263, 20, 65398, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 633, 61, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2628, 364, 172, 65533, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 319, 171, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(35482, 152, 207, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 166, 232, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 535, 206, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 449, 183, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 261, 24, 65419, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(35377, 337, 89, 8, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 478, 56, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2699, 260, 118, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 7, 283, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 14, 33, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 29, 35, 11, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 104, 9, 15, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 310, 290, 65499, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 78, 275, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 247, 282, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 58, 233, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 16, 287, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 27, 268, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 389, 246, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 122, 215, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 198, 220, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 501, 241, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 2, 55, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 26, 73, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 404, 295, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 397, 301, 0, 5402));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 271, 269, 0, 5402));
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

