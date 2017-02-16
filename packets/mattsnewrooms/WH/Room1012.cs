using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1012 : Room
  {
        public Room1012()
            : base(1012, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 516, 176, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 567, 172, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 458, 176, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 129, 107, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(141, 281, 104, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 211, 304, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 158, 105, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 496, 103, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(245, 215, 48, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 147, 349, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 329, 351, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 143, 108, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 111, 115, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 89, 111, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 120, 103, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 80, 113, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 116, 117, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 154, 113, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 48, 308, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 38, 312, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 65480, 140, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 41, 237, 0, 1012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 34, 323, 0, 1012));
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

