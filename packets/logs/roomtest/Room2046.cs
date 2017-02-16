using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2046 : Room
  {
        public Room2046()
            : base(2046, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 105, 109, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 609, 122, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 339, 120, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 56, 325, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 125, 323, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 308, 103, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 24, 175, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 338, 122, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(33012, 221, 59, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 439, 188, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 66, 267, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(245, 287, 62, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 335, 118, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 38, 287, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 144, 302, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 108, 275, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 576, 155, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 225, 285, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 25, 282, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 219, 272, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 371, 190, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 155, 170, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 36, 155, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 482, 163, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(33003, 248, 172, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 367, 189, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 511, 160, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 27, 174, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 45, 156, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 121, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 533, 124, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 557, 123, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 581, 124, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 124, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 123, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 30, 316, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 579, 162, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 490, 167, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 454, 189, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 385, 182, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(33003, 257, 170, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 325, 184, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 164, 164, 0, 2046));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 48, 150, 0, 2046));
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

