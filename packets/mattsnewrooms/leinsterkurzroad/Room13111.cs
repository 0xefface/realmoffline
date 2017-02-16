using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13111 : Room
  {
        public Room13111()
            : base(13111, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 294, 104, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 104, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 141, 104, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 415, 135, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 216, 236, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 162, 237, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 462, 182, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 3, 355, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 101, 242, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 382, 228, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(32994, 427, 219, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 578, 220, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 448, 183, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1110, 604, 193, 65516, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 189, 137, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(32920, 5, 143, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 649, 160, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(243, 338, 57, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 563, 214, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 556, 229, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 346, 242, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 502, 248, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(32994, 596, 256, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 4, 139, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 16, 139, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 28, 139, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 40, 139, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 173, 134, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 184, 134, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 196, 134, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 211, 134, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 577, 153, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 588, 153, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 600, 153, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 609, 153, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 621, 153, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 627, 153, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 635, 153, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 432, 131, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 288, 131, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 306, 131, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 324, 131, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 342, 131, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 360, 131, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 378, 131, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 396, 131, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 414, 131, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 451, 130, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 475, 132, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 491, 132, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 509, 132, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 527, 132, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 537, 132, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 569, 131, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 586, 131, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 604, 131, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 622, 131, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 633, 132, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 43, 119, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 54, 119, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 66, 119, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 77, 119, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 89, 119, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 100, 119, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 112, 119, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 124, 119, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 137, 119, 0, 13111));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 147, 120, 0, 13111));
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

