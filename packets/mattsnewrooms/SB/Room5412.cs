using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5412 : Room
  {
        public Room5412()
            : base(5412, "Magic Tomes")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 251, 82, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 614, 210, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 526, 72, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 328, 83, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 450, 78, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 192, 243, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(32881, 297, 239, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 577, 234, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 272, 239, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 542, 242, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 633, 239, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 272, 91, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2634, 522, 89, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 399, 90, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 629, 190, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 270, 93, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 387, 91, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 519, 90, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 299, 188, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 299, 192, 12, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 642, 280, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 627, 148, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 190, 232, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 242, 230, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(32814, 357, 233, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 194, 238, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 607, 9, 65334, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(32828, 611, 210, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 178, 185, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 259, 239, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 178, 75, 65386, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(32881, 299, 231, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 332, 234, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 496, 232, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(32881, 268, 232, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2708, 484, 142, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(35561, 517, 184, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2802, 503, 196, 26, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 360, 233, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(104, 135, 232, 0, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 182, 15, 65386, 5412));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 181, 44, 65386, 5412));
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

