using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1013 : Room
  {
        public Room1013()
            : base(1013, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 68, 210, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 558, 148, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 80, 205, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 401, 316, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 440, 333, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 382, 315, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 324, 330, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 554, 335, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 555, 149, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(32972, 113, 211, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 175, 227, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 248, 196, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 567, 194, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 527, 152, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 65, 324, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 439, 213, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 409, 195, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 259, 197, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 522, 212, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 608, 210, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 319, 197, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 494, 197, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 595, 198, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 340, 103, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 65453, 106, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(146, 76, 107, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 414, 194, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 163, 176, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 157, 151, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 167, 104, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 160, 125, 0, 1013));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 160, 107, 0, 1013));
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

