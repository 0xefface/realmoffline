using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5300 : Room
  {
        public Room5300()
            : base(5300, "Monmouth Necessaries")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 128, 73, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 200, 79, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 392, 72, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 325, 78, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 65509, 238, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 444, 252, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 46, 248, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 452, 241, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 112, 304, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 30, 314, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2631, 147, 91, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 272, 91, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2634, 393, 90, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 33, 231, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 141, 96, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 270, 92, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 387, 92, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2953, 65499, 216, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 391, 192, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 392, 198, 12, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 136, 198, 13, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 134, 192, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 355, 246, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 181, 229, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(32814, 342, 227, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 452, 230, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 79, 242, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 185, 248, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(32828, 499, 163, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 355, 248, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2244, 176, 245, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 11, 235, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 9, 172, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 15, 94, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(35514, 548, 65, 65454, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 483, 1, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 518, 72, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2642, 518, 45, 65438, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2642, 448, 56, 65438, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 448, 73, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2651, 466, 52, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2654, 474, 24, 65445, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(32793, 508, 155, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 499, 164, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 627, 2, 65506, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(32793, 579, 68, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 627, 4, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2736, 529, 40, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 46, 3, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(35514, 148, 58, 65453, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 243, 225, 0, 5300));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 275, 227, 0, 5300));
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

