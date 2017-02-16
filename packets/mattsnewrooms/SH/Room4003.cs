using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4003 : Room
  {
        public Room4003()
            : base(4003, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 518, 107, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 158, 106, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 51, 123, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32962, 327, 103, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2539, 324, 109, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 510, 234, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 505, 240, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 328, 73, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 327, 230, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 325, 106, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 594, 119, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 395, 115, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 259, 113, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 210, 195, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 45, 196, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(194, 622, 84, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(195, 10, 50, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 16, 124, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 313, 181, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 323, 128, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 342, 173, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 334, 169, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 324, 166, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 318, 174, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32994, 295, 186, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 301, 206, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 77, 125, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 55, 124, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 31, 125, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 7, 125, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 555, 119, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 578, 119, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 601, 118, 0, 4003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 625, 118, 0, 4003));
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

