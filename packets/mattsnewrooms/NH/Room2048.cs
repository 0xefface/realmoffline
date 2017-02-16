using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2048 : Room
  {
        public Room2048()
            : base(2048, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 72, 103, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 107, 110, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 484, 110, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 506, 308, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 145, 140, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 549, 309, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 499, 310, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 528, 309, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 127, 137, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 289, 104, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 292, 47, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 144, 143, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 543, 334, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 110, 307, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 456, 323, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 261, 230, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 303, 243, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 278, 259, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 268, 245, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 280, 237, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 301, 257, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 288, 104, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 100, 240, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 214, 240, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 195, 267, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 227, 244, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 290, 117, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 289, 142, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 303, 183, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 215, 259, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 692, 191, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 97, 255, 0, 2048));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 242, 242, 0, 2048));
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

