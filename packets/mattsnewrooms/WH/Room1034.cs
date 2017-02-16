using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1034 : Room
  {
        public Room1034()
            : base(1034, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 321, 107, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 266, 177, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 272, 213, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 303, 176, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 311, 183, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 373, 257, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 462, 252, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 411, 249, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 387, 239, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 215, 185, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 257, 183, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 287, 186, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 230, 174, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 237, 168, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 219, 179, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 243, 185, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 292, 170, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 248, 164, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 572, 215, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 454, 104, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 609, 107, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 598, 108, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 383, 106, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 537, 109, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 564, 98, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(141, 9, 106, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 472, 209, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 456, 160, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 451, 126, 0, 1034));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 466, 144, 0, 1034));
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

