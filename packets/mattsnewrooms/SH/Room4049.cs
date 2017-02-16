using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4049 : Room
  {
        public Room4049()
            : base(4049, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 170, 108, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 523, 119, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 183, 120, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 407, 228, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 372, 252, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 306, 228, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 365, 236, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 593, 125, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 109, 131, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 310, 213, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 465, 107, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 375, 242, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 428, 119, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 181, 134, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 123, 130, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 502, 124, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 23, 268, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 4, 269, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 257, 222, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 246, 221, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 302, 227, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 359, 235, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 261, 225, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 94, 131, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 116, 132, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 139, 133, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 163, 133, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 185, 134, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 199, 132, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 414, 119, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 438, 121, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 462, 121, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 473, 124, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 497, 125, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 520, 125, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 543, 125, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 126, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 126, 0, 4049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 614, 125, 0, 4049));
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

