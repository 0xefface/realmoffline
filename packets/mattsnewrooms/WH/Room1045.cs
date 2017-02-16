using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1045 : Room
  {
        public Room1045()
            : base(1045, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 221, 106, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 381, 133, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 378, 146, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32972, 370, 134, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 408, 147, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 362, 139, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32978, 88, 259, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32979, 281, 257, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32980, 499, 251, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(213, 615, 255, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 631, 105, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(141, 45, 106, 15, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 33, 324, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 131, 327, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 85, 316, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 352, 248, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 373, 299, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 413, 298, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 375, 239, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 404, 245, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 328, 245, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 454, 294, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 206, 296, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 186, 270, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 186, 289, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 187, 300, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 205, 273, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 205, 289, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 170, 275, 0, 1045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 170, 298, 0, 1045));
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

