using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2510 : Room
  {
        public Room2510()
            : base(2510, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 93, 128, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(35511, 573, 134, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 440, 139, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 632, 140, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 196, 140, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 575, 137, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 210, 142, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 351, 140, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 271, 139, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 118, 136, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 47, 135, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 509, 222, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 540, 230, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 513, 221, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 562, 150, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 555, 146, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 580, 234, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 223, 234, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 145, 179, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 16, 195, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 209, 216, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 127, 239, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 447, 323, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 549, 231, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 264, 185, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 240, 246, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 400, 266, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 490, 182, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 566, 178, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 614, 176, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 260, 353, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 158, 242, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 36, 196, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 196, 233, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 304, 309, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(1110, 205, 289, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(221, 95, 238, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(215, 55, 196, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(221, 158, 287, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 200, 272, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 167, 288, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 51, 288, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 102, 321, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 82, 321, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 63, 321, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 44, 321, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 27, 321, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 168, 320, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 188, 321, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 206, 321, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 224, 321, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 242, 321, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 261, 321, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65529, 228, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65529, 249, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65529, 267, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65529, 283, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65529, 193, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65529, 173, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 44, 134, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 134, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 100, 136, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 139, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 253, 138, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 277, 138, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 285, 138, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 327, 138, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 349, 139, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 372, 139, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 139, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 140, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 606, 140, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 578, 135, 0, 2510));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 560, 137, 0, 2510));
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

