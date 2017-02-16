using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1002 : Room
  {
        public Room1002()
            : base(1002, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(172, 393, 103, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32941, 636, 103, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 74, 318, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32830, 576, 129, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 158, 192, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 503, 318, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 163, 196, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 562, 318, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 501, 321, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 473, 325, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 492, 319, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 310, 113, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 490, 114, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 312, 132, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 187, 123, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 260, 120, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 342, 117, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 367, 120, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 404, 116, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 221, 119, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 545, 117, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 580, 119, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 616, 117, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 306, 133, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 141, 113, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 235, 115, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 281, 110, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 345, 115, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 442, 111, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 505, 108, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 556, 121, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 621, 115, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 318, 129, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 132, 121, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 275, 117, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 312, 115, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 404, 116, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 264, 2, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(171, 8, 104, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 5, 109, 0, 1002));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 392, 123, 0, 1002));
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

