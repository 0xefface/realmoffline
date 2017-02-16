using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2513 : Room
  {
        public Room2513()
            : base(2513, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 93, 128, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(35511, 566, 130, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 327, 134, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 363, 141, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 589, 134, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 183, 135, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 489, 134, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 210, 142, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 320, 147, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 265, 138, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 118, 132, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 444, 266, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 554, 213, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 94, 218, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 60, 129, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 35, 208, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 96, 219, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 28, 196, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 132, 203, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 22, 208, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 127, 202, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 615, 208, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 440, 265, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 280, 246, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 264, 185, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 321, 181, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 380, 179, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 490, 182, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 566, 178, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 614, 176, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 260, 353, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 8, 220, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 7, 223, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 436, 260, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 297, 261, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 158, 134, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 181, 132, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 206, 141, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 223, 141, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 203, 133, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 249, 136, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 276, 137, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 303, 146, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 326, 146, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 346, 146, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 359, 138, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 383, 139, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 65, 126, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 485, 133, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 500, 134, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 562, 134, 0, 2513));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 585, 134, 0, 2513));
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

