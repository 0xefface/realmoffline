using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5401 : Room
  {
        public Room5401()
            : base(5401, "The Perfect Crime")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 47, 78, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 144, 71, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 239, 72, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 164, 77, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(35369, 310, 290, 300, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 344, 63, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2610, 102, 93, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2549, 144, 184, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(132, 320, 223, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 145, 238, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2555, 143, 181, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2549, 238, 184, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2555, 237, 181, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2610, 228, 86, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 8, 223, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 219, 244, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 259, 357, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 248, 243, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 25, 196, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(133, 329, 216, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 316, 87, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 65521, 108, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(134, 336, 226, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 455, 52, 65436, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2802, 313, 140, 20, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2793, 329, 134, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 402, 56, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 382, 69, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 331, 227, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 235, 233, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 141, 237, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 57, 230, 65516, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(131, 11, 264, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 441, 54, 65426, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(32782, 65505, 282, 0, 5401));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 218, 255, 0, 5401));
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

