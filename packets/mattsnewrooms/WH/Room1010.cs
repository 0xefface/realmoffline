using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1010 : Room
  {
        public Room1010()
            : base(1010, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 322, 105, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 426, 326, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 229, 209, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 254, 214, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 306, 214, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 336, 213, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 306, 226, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 340, 222, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 250, 224, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 248, 216, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 215, 220, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 254, 209, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 290, 205, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 292, 220, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 239, 203, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 206, 202, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 453, 170, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 490, 167, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 140, 150, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(241, 150, 71, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 505, 111, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 277, 211, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 221, 200, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 621, 116, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 458, 98, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 266, 102, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(141, 481, 112, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 12, 98, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 477, 112, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 500, 112, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 522, 116, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 546, 116, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 568, 116, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 116, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 614, 116, 0, 1010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 633, 116, 0, 1010));
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

