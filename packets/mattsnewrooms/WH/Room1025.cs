using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1025 : Room
  {
        public Room1025()
            : base(1025, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 36, 140, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 554, 158, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 43, 138, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 476, 317, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 539, 318, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 433, 319, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 383, 329, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(33000, 234, 115, 20, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 274, 107, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(32830, 316, 193, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 315, 187, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 313, 191, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 271, 108, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 273, 106, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 86, 283, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 87, 283, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 53, 140, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 220, 104, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 615, 117, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 65454, 104, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 33, 128, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 230, 116, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(33003, 271, 227, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 417, 236, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 559, 236, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(141, 612, 90, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 230, 185, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 249, 144, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 184, 238, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 52, 240, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 259, 239, 0, 1025));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 230, 242, 0, 1025));
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

