using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1024 : Room
  {
        public Room1024()
            : base(1024, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 567, 301, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32890, 345, 214, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 94, 317, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 60, 139, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 107, 232, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32834, 25, 129, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32834, 112, 138, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 312, 135, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32868, 178, 138, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 18, 139, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 155, 346, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 336, 188, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 387, 202, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 548, 302, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 378, 207, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 315, 215, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 382, 210, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 155, 140, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(241, 229, 40, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(145, 599, 107, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 342, 222, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32830, 323, 212, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 363, 214, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 101, 139, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 51, 104, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 544, 232, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 329, 232, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 206, 138, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 268, 317, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 125, 142, 0, 1024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32834, 218, 138, 0, 1024));
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

