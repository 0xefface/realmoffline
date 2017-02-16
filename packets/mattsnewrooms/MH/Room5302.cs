using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5302 : Room
  {
        public Room5302()
            : base(5302, "Clothes and More")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 149, 34, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 159, 54, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 241, 52, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 346, 31, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 432, 55, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 443, 71, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 475, 61, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 588, 43, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 287, 66, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 524, 75, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 503, 72, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 218, 72, 15, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 383, 225, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 403, 1, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 150, 64, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 388, 73, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 630, 229, 108, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 645, 229, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2644, 524, 167, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2644, 290, 154, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2643, 290, 218, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2643, 524, 227, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 524, 232, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 290, 223, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2650, 318, 218, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2650, 555, 227, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2643, 608, 206, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2644, 608, 140, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 512, 167, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 228, 77, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 278, 157, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 278, 222, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 103, 131, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 388, 169, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 103, 186, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 512, 230, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 463, 242, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 385, 220, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 387, 209, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 103, 182, 65518, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 225, 224, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 458, 232, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 197, 218, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 398, 229, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 234, 174, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 374, 244, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 445, 178, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2710, 293, 263, 159, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 223, 155, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 434, 159, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 665, 78, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2666, 235, 219, 65522, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2666, 445, 223, 65522, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 255, 233, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 622, 238, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 314, 237, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2957, 83, 45, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2957, 51, 56, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 541, 243, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 384, 225, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 665, 233, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 342, 225, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 436, 238, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(32828, 512, 241, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 35, 325, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 52, 5, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 141, 284, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 68, 246, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 65519, 42, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2806, 319, 224, 85, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2792, 327, 223, 77, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 339, 251, 0, 5302));
          this.AddRoomDecoration(RoomDecoration.FromCode(7904, 192, 231, 0, 5302));
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

