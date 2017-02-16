using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2031 : Room
  {
        public Room2031()
            : base(2031, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 89, 112, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 531, 112, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 126, 115, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 363, 296, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 172, 182, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 172, 188, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 383, 286, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 169, 185, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(32943, 309, 106, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(244, 257, 38, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 248, 356, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 174, 189, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 489, 172, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 434, 304, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 484, 171, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 315, 297, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 477, 171, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 512, 163, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 440, 287, 0, 2031));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 429, 282, 0, 2031));
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

