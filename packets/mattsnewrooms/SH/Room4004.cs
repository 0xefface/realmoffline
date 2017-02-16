using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4004 : Room
  {
        public Room4004()
            : base(4004, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Up;
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 431, 283, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 389, 265, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 409, 287, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 410, 277, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 167, 103, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 459, 103, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 541, 103, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 99, 131, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 36, 123, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 594, 115, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32962, 119, 89, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(195, 618, 48, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 169, 125, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 617, 124, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(198, 272, 53, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 130, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 87, 130, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 122, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 36, 122, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 122, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 147, 124, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 124, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 192, 124, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 606, 122, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 122, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 563, 113, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 587, 113, 0, 4004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 613, 112, 0, 4004));
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

