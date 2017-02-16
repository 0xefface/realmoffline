using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7007 : Room
  {
        public Room7007()
            : base(7007, "Barbary Clips")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 358, 70, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 271, 72, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 207, 47, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 456, 65, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 481, 66, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2649, 441, 67, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 206, 174, 30, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 347, 220, 49, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 347, 228, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 447, 138, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 494, 130, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 408, 238, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2656, 406, 216, 65526, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2651, 407, 150, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 491, 195, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2654, 487, 100, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 148, 75, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 174, 212, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2649, 426, 234, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2644, 407, 175, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 448, 236, 133, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 445, 234, 58, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 258, 227, 125, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 189, 239, 149, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2642, 447, 224, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2642, 494, 215, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 394, 250, 149, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 264, 246, 168, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 501, 18, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2609, 433, 103, 38, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 397, 203, 20, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 165, 180, 122, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 397, 230, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 485, 100, 49, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2656, 397, 155, 47, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2654, 438, 60, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 161, 209, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 476, 245, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 342, 239, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2642, 408, 233, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 342, 110, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 344, 105, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 522, 235, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2671, 162, 132, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 287, 217, 60, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2673, 350, 226, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2674, 348, 156, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2676, 155, 158, 65513, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 246, 213, 65520, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 205, 178, 65508, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 205, 179, 42, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 160, 212, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 458, 161, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2953, 176, 15, 65354, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 523, 249, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 489, 255, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 161, 160, 20, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 542, 244, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 161, 174, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 15, 1, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 496, 4, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 594, 54, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 75, 157, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 374, 244, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 268, 185, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 398, 188, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(7904, 510, 246, 0, 7007));
          this.AddRoomDecoration(RoomDecoration.FromCode(40672, 591, 180, 0, 7007));
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

