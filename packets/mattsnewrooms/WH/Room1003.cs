using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1003 : Room
  {
        public Room1003()
            : base(1003, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32939, 316, 102, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 138, 241, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 86, 322, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 106, 131, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32893, 469, 267, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 225, 127, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 399, 117, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 282, 116, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 116, 127, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 328, 117, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 289, 119, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32868, 97, 128, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 259, 121, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 71, 130, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 39, 133, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 13, 131, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 470, 266, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 182, 132, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 456, 277, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 488, 272, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 430, 263, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 440, 247, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 365, 120, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 171, 130, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 26, 129, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 78, 129, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 144, 128, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 502, 268, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 493, 279, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 424, 274, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 674, 123, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(172, 609, 101, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 448, 120, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 631, 123, 0, 1003));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 356, 124, 0, 1003));
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

