using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1000 : Room
  {
        public Room1000()
            : base(1000, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Left;
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 574, 327, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(122, 398, 209, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32868, 15, 336, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 537, 121, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 236, 122, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 315, 125, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 289, 124, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 121, 238, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(110, 349, 204, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 578, 121, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 505, 102, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(172, 247, 102, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(172, 610, 60, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 368, 121, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 205, 113, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32868, 336, 117, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 516, 114, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 199, 117, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 275, 116, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 335, 118, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 407, 116, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 464, 117, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 517, 116, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 565, 116, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 615, 115, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 249, 119, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 373, 120, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 617, 117, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 593, 116, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 370, 199, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 479, 118, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 303, 123, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 403, 203, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(245, 474, 1, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(172, 638, 72, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 155, 118, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 618, 118, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 401, 212, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 412, 197, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 536, 121, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 572, 121, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 62, 108, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32868, 65500, 119, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32868, 65503, 150, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32868, 65513, 178, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 65513, 216, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 65534, 258, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32868, 9, 293, 0, 1000));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 48, 316, 0, 1000));
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

