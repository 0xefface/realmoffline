using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13010 : Room
  {
        public Room13010()
            : base(13010, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(35510, 54, 107, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 358, 119, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 522, 106, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 612, 138, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 107, 129, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 57, 319, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(33014, 12, 20, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 637, 168, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 2, 105, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 81, 112, 65526, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(33013, 58, 28, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 214, 115, 10, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 206, 167, 65466, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 232, 211, 65497, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 133, 236, 65504, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 533, 294, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(32920, 65534, 135, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 71, 226, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 210, 126, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 221, 168, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(213, 191, 226, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(209, 245, 227, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(32978, 358, 226, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(32979, 474, 225, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 647, 222, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 160, 241, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 160, 258, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 401, 241, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 401, 256, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 637, 164, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 625, 164, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 613, 164, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 602, 164, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 10, 131, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 35, 128, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 572, 235, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 573, 254, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 8, 274, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65530, 292, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65533, 224, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65530, 204, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 641, 267, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 646, 286, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 644, 220, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 645, 201, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 315, 277, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(32991, 174, 275, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 7, 264, 0, 13010));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 619, 262, 0, 13010));
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

