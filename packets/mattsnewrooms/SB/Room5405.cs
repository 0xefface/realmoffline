using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5405 : Room
  {
        public Room5405()
            : base(5405, "Comestibles")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2508, 123, 77, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 274, 95, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 337, 96, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 376, 90, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 412, 73, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 239, 124, 1, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 356, 220, 11, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 421, 257, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 354, 263, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2799, 80, 207, 96, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 307, 217, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 406, 220, 20, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 342, 105, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 281, 214, 15, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 331, 206, 15, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 381, 197, 15, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 61, 199, 21, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 14, 200, 29, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 310, 290, 65397, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 9, 224, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 292, 259, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 29, 244, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 0, 188, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 25, 223, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 44, 249, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 37, 76, 65397, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(35478, 123, 82, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 121, 281, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 492, 218, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 433, 246, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 72, 197, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 27, 191, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(35576, 112, 206, 74, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 338, 253, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 65533, 227, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 50, 227, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 437, 235, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 384, 231, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 360, 240, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 321, 244, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 296, 243, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(186, 146, 259, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 515, 3, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 623, 3, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 543, 32, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 535, 55, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 602, 71, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 546, 70, 65514, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 609, 105, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 40, 212, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 65512, 90, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 11, 8, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 453, 242, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2754, 203, 119, 65499, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2752, 200, 260, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2751, 199, 209, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 228, 209, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 227, 263, 0, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(2758, 227, 124, 65505, 5405));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 470, 240, 0, 5405));
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

