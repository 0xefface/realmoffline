using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1033 : Room
  {
        public Room1033()
            : base(1033, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32970, 596, 120, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32971, 576, 124, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 608, 125, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32972, 599, 129, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 632, 131, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32877, 95, 318, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 149, 309, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 97, 318, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 76, 324, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 307, 273, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 48, 315, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 477, 103, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32941, 368, 106, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32941, 158, 109, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(246, 604, 61, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32877, 65506, 302, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 76, 302, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 591, 284, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(142, 385, 108, 0, 1033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32913, 498, 90, 0, 1033));
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

