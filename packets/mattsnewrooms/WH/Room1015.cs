using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1015 : Room
  {
        public Room1015()
            : base(1015, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 70, 322, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 458, 288, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 65509, 196, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(125, 452, 283, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 77, 140, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 55, 140, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 412, 267, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 41, 136, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 136, 324, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 267, 190, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 412, 185, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 561, 186, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 26, 215, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 248, 207, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 131, 211, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 64, 197, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 146, 194, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 450, 279, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 291, 190, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 524, 201, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 511, 187, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 618, 201, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 338, 103, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 48, 104, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(142, 615, 106, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(141, 222, 87, 0, 1015));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 118, 195, 0, 1015));
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

