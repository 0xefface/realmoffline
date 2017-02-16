using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5308 : Room
  {
        public Room5308()
            : base(5308, "Monmouth Gatekeeper")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 359, 52, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 272, 53, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 207, 28, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 456, 53, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 481, 61, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2649, 444, 57, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 204, 216, 72, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 345, 189, 20, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 345, 213, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 447, 126, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 494, 120, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 408, 229, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2656, 406, 215, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2651, 396, 91, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 491, 195, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2654, 487, 100, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 148, 72, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2650, 476, 216, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2649, 424, 225, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 458, 154, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 447, 229, 133, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 445, 226, 58, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 263, 148, 45, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 203, 148, 58, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2642, 447, 222, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2642, 495, 211, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 384, 180, 76, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 271, 150, 69, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 501, 18, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2609, 433, 103, 38, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 301, 176, 20, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 247, 154, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 301, 206, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 485, 100, 49, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2656, 397, 101, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2654, 438, 60, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 160, 197, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 211, 213, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 342, 229, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 271, 223, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 342, 108, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 246, 182, 31, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 247, 203, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2671, 160, 122, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 279, 230, 74, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2673, 349, 213, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2674, 348, 152, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2676, 161, 173, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 229, 222, 68, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 205, 182, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 205, 175, 31, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2510, 232, 198, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(180, 276, 203, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(35722, 623, 183, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 172, 198, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 147, 206, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 129, 178, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 65499, 208, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 406, 233, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(35722, 592, 229, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 65535, 192, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 133, 22, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 156, 143, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 551, 190, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 98, 1, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 108, 31, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 545, 2, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 554, 48, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 65526, 190, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(186, 238, 198, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(27, 608, 101, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(35500, 407, 193, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(35502, 408, 194, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2733, 253, 199, 0, 5308));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 351, 245, 0, 5308));
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

