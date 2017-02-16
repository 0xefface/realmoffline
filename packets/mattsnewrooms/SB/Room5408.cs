using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5408 : Room
  {
        public Room5408()
            : base(5408, "Look Your Best")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 97, 29, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 159, 54, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 241, 52, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 346, 31, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 499, 248, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2808, 307, 157, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 401, 171, 58, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 41, 161, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 400, 16, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 150, 64, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2799, 318, 161, 27, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 625, 230, 108, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 645, 229, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 65529, 215, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2644, 290, 154, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2643, 290, 218, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 65522, 196, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2650, 376, 207, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 290, 223, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2650, 318, 218, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 9, 153, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 22, 127, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 22, 239, 105, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 599, 204, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 174, 69, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 278, 157, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 278, 222, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 51, 125, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 430, 123, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 51, 183, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 65520, 178, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 50, 194, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 74, 210, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 430, 191, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 68, 197, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 225, 224, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 377, 53, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 204, 219, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 310, 247, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 234, 174, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 88, 151, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 155, 71, 15, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 77, 132, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 223, 155, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 283, 72, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2666, 89, 196, 65522, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2666, 235, 219, 65522, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 22, 199, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 255, 233, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 671, 192, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2958, 104, 14, 65368, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2957, 12, 159, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2957, 49, 59, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 541, 243, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 384, 225, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 665, 233, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 342, 225, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 134, 219, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 544, 268, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2710, 293, 263, 159, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 627, 205, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(44, 6, 184, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 569, 31, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 506, 6, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 508, 1, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 522, 177, 108, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 631, 202, 108, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 518, 215, 108, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 348, 222, 0, 5408));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 506, 204, 0, 5408));
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

