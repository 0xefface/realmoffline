using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6913 : Room
  {
        public Room6913()
            : base(6913, "Valhalla Hall")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.UpLeftRight;
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 97, 164, 30, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 516, 128, 20, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2517, 45, 16, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 72, 146, 30, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 254, 128, 20, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2517, 138, 1, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2518, 92, 42, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 237, 14, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 412, 19, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 530, 19, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 613, 14, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2758, 119, 165, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2763, 416, 92, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 315, 19, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2758, 161, 176, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2757, 142, 180, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 122, 177, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 101, 179, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2758, 61, 185, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2757, 83, 180, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 43, 195, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 22, 200, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2758, 1, 205, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2757, 0, 154, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 161, 77, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 142, 128, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2758, 119, 141, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2757, 163, 126, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 18, 146, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 119, 89, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 141, 93, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 160, 43, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2758, 39, 163, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 500, 156, 20, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 238, 156, 20, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(35531, 395, 92, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2758, 65534, 104, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2757, 40, 111, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 99, 122, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 59, 90, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2758, 79, 89, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2757, 99, 59, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 140, 58, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 20, 114, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2758, 37, 65, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2757, 18, 62, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 65535, 53, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 118, 44, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 78, 43, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2757, 59, 52, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 303, 174, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 279, 174, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 306, 122, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 308, 159, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 435, 175, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 350, 173, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 329, 174, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 349, 127, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 325, 126, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 347, 78, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 328, 83, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 442, 122, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 433, 87, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 460, 174, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 463, 122, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 485, 126, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 455, 72, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 484, 174, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 507, 174, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 257, 174, 65533, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 183, 174, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 528, 174, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 183, 119, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 184, 68, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 206, 121, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 208, 173, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 234, 174, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 231, 146, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 230, 93, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 206, 69, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 265, 60, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 249, 63, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 280, 64, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 327, 62, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 305, 58, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 229, 49, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 480, 54, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 506, 60, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 552, 173, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 530, 64, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 549, 62, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 572, 172, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 572, 159, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 570, 109, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 593, 140, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 618, 172, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 591, 88, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 596, 173, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 616, 122, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 572, 60, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 593, 37, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 614, 69, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2631, 562, 73, 40, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2631, 255, 72, 40, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 426, 83, 50, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 328, 83, 50, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2631, 568, 175, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2631, 256, 176, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 310, 177, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 504, 176, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2623, 65522, 207, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2623, 65492, 115, 50, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2624, 51, 195, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2624, 49, 90, 40, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 180, 242, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(32782, 86, 217, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(32782, 65513, 235, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 85, 258, 65526, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2649, 119, 252, 65526, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2650, 177, 243, 65526, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 331, 300, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 14, 259, 65526, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2105, 66, 256, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 572, 183, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 229, 183, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 407, 168, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 233, 175, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 131, 192, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 87, 200, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2642, 172, 177, 0, 6913));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 172, 101, 0, 6913));
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

