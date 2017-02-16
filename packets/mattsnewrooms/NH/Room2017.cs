using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2017 : Room
  {
        public Room2017()
            : base(2017, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 103, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 377, 145, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 368, 145, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 633, 142, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 54, 324, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(33014, 12, 20, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 627, 121, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 145, 104, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 161, 111, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(33013, 58, 28, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 140, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 601, 121, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 123, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 376, 149, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(180, 239, 240, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(181, 325, 217, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(182, 348, 257, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(180, 256, 221, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(182, 255, 265, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(32948, 388, 238, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(32948, 374, 221, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(182, 214, 236, 0, 2017));
          this.AddRoomDecoration(RoomDecoration.FromCode(32950, 387, 237, 0, 2017));
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

