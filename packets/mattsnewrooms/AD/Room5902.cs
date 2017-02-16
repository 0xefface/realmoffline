using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5902 : Room
  {
        public Room5902()
            : base(5902, "Swiper's Seminary")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(34290, 120, 36, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(1522, 120, 62, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(1522, 137, 72, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(34288, 24, 221, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 571, 231, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 322, 225, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 225, 56, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 41, 130, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 260, 218, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 274, 205, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 159, 44, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 90, 37, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 131, 40, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 191, 49, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 108, 48, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 71, 45, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 144, 41, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 378, 222, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(1523, 63, 206, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(1521, 21, 61, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 50, 211, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(35369, 65525, 208, 69, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(1523, 232, 47, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(1520, 22, 53, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(34288, 214, 75, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(34288, 151, 86, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(1523, 191, 78, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 300, 13, 65511, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 405, 17, 65509, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2527, 349, 23, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 518, 19, 65509, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 555, 65514, 65509, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 599, 17, 65509, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2527, 574, 26, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 312, 143, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 311, 220, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 536, 223, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 537, 146, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 327, 193, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 328, 115, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 552, 195, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 553, 118, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2605, 324, 8, 65501, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2605, 460, 19, 65511, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2605, 592, 7, 65501, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2606, 354, 66, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2606, 580, 72, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 602, 226, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 551, 227, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 294, 209, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 344, 230, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 616, 195, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2802, 446, 62, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2632, 466, 20, 65491, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 349, 231, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 298, 191, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 263, 220, 0, 5902));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 578, 237, 0, 5902));
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

