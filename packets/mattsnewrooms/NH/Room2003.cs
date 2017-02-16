using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2003 : Room
  {
        public Room2003()
            : base(2003, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 296, 115, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 486, 135, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 635, 121, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32917, 69, 124, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(106, 183, 318, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 26, 123, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 48, 123, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 72, 123, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 94, 122, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 130, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 444, 130, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 468, 130, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 608, 118, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 630, 119, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 564, 113, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 541, 113, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 3, 111, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 370, 227, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 399, 228, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 389, 175, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 409, 175, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 403, 110, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 408, 108, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 401, 127, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 399, 144, 0, 2003));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 412, 136, 0, 2003));
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

