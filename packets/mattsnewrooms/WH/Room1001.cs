using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1001 : Room
  {
        public Room1001()
            : base(1001, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(171, 303, 104, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 117, 212, 65528, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 598, 125, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 97, 221, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 401, 317, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 449, 330, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 371, 319, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 319, 332, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 286, 117, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 167, 128, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 24, 132, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 236, 129, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 469, 119, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 534, 119, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 612, 116, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 389, 116, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 211, 117, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(32868, 114, 128, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 428, 119, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 22, 130, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 187, 130, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 227, 132, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 336, 121, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 372, 121, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 461, 121, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 498, 123, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 535, 120, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 625, 118, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 64, 129, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 143, 129, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 84, 130, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 118, 129, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(32939, 172, 89, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 592, 124, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 105, 133, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 428, 123, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 11, 135, 0, 1001));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 144, 219, 0, 1001));
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

