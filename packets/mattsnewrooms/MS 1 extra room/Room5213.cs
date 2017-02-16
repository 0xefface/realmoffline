using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5213 : Room
  {
        public Room5213()
            : base(5213, "Mikal's Cafe")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.DownRight;
          this.AddRoomDecoration(RoomDecoration.FromCode(2606, 161, 91, 150, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 477, 4, 65526, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(35481, 93, 6, 65437, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 4, 8, 65437, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 158, 8, 65437, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 182, 8, 65437, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 466, 8, 65437, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 620, 7, 65437, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 51, 113, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 130, 110, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 45, 109, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 626, 114, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 444, 116, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 65521, 118, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 200, 117, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 529, 115, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 65526, 189, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 162, 173, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 143, 313, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 490, 310, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(32854, 489, 165, 50, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(85, 487, 160, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(2953, 594, 152, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 156, 102, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 126, 112, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 545, 143, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 0, 101, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 565, 104, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 448, 92, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 65496, 204, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 485, 161, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 565, 2, 65526, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 2, 178, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 639, 185, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 65, 115, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 614, 174, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 602, 196, 0, 5213));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 78, 146, 0, 5213));
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

