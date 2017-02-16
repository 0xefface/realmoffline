using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5404 : Room
  {
        public Room5404()
            : base(5404, "Luscious Locks")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 405, 46, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 463, 69, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 488, 58, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 319, 24, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 216, 46, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 591, 37, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 202, 59, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 196, 44, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 425, 178, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 543, 200, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 502, 188, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2557, 503, 182, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2556, 560, 173, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2557, 426, 172, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 368, 206, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2627, 135, 60, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 265, 63, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 548, 88, 20, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2627, 419, 83, 18, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 445, 80, 28, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 489, 85, 8, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 368, 87, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 588, 217, 99, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 509, 221, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 592, 232, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 639, 208, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 158, 211, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 391, 206, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 211, 206, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 469, 217, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 423, 212, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 165, 26, 65374, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 622, 208, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 85, 0, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 83, 2, 65486, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 81, 2, 65492, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 11, 23, 65486, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 310, 290, 65486, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 540, 268, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 395, 270, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 597, 220, 0, 5404));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 769, 121, 0, 5404));
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

