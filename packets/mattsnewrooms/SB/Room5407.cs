using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5407 : Room
  {
        public Room5407()
            : base(5407, "Silverbrook Gatekeeper")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 359, 52, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 272, 53, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 207, 28, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 456, 53, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 481, 61, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2649, 444, 57, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 204, 216, 72, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 345, 189, 20, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 345, 213, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 447, 126, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 494, 120, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 408, 229, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2656, 406, 215, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2651, 396, 91, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 491, 195, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2654, 487, 100, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 148, 72, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2650, 476, 216, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2649, 424, 225, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 458, 154, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 447, 229, 133, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 445, 226, 58, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 263, 148, 45, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 203, 148, 58, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2642, 447, 222, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2642, 495, 211, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 388, 472, 368, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 255, 195, 117, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 501, 18, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2609, 433, 103, 38, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 301, 176, 20, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 248, 153, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 301, 206, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 485, 100, 49, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2656, 397, 101, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2654, 438, 60, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 160, 197, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 211, 213, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 342, 229, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 271, 223, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 342, 108, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 246, 182, 31, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 247, 203, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2671, 160, 122, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 281, 230, 74, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2673, 349, 213, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2674, 348, 152, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2676, 161, 173, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 229, 222, 68, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 205, 182, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 205, 175, 31, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2510, 232, 198, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 136, 207, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 406, 233, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(35722, 591, 227, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 545, 208, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 658, 57, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 161, 72, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 590, 193, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(35722, 630, 182, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 623, 153, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 158, 185, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 147, 206, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 187, 206, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 358, 239, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 457, 231, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 395, 234, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 504, 233, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 203, 211, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 534, 229, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 513, 220, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 598, 229, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 442, 234, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 409, 237, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 564, 231, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 183, 212, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 201, 203, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 49, 51, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 58, 57, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 84, 1, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 70, 108, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 95, 262, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 68, 64, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 65514, 111, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 150, 266, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 12, 152, 0, 5407));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 358, 249, 0, 5407));
          this.AllowCasting = False;
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

