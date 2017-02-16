using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7310 : Room
  {
        public Room7310()
            : base(7310, "Sundries World")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 360, 68, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 271, 69, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 185, 42, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 510, 63, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 501, 70, 28, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 510, 120, 49, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2654, 438, 60, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 471, 199, 30, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 147, 198, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 286, 82, 20, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2601, 413, 246, 165, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 310, 290, 402, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 278, 76, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2628, 288, 78, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 219, 82, 30, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 252, 72, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2606, 503, 63, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 509, 122, 49, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2651, 479, 49, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2651, 484, 47, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 461, 70, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 249, 224, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(35012, 394, 246, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 191, 165, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 461, 181, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 207, 176, 25, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(123, 540, 224, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 546, 342, 241, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(1542, 454, 250, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(1507, 556, 224, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(44, 446, 248, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(34275, 536, 226, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(1506, 518, 228, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(1597, 521, 219, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(34365, 465, 229, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(34364, 396, 232, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(34365, 195, 217, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(34365, 250, 213, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(34364, 239, 218, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 136, 214, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(34290, 572, 317, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(1522, 593, 221, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(1586, 594, 209, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(1587, 528, 216, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(1588, 245, 226, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(34355, 612, 86, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(1538, 570, 58, 65385, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(1585, 632, 14, 65452, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(1586, 626, 185, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(1585, 310, 290, 65452, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(1586, 615, 150, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(1587, 631, 279, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(32818, 119, 193, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 135, 199, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 20, 2, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 65490, 4, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 59, 36, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 117, 37, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 35, 69, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(32952, 49, 15, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 162, 215, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(1508, 5, 116, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 595, 49, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 539, 2, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 611, 51, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 138, 32, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(14, 253, 237, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(32782, 408, 254, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(14, 421, 248, 0, 7310));
          this.AddRoomDecoration(RoomDecoration.FromCode(14, 274, 236, 0, 7310));
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

