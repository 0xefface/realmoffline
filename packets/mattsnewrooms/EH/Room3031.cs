using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3031 : Room
  {
        public Room3031()
            : base(3031, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 573, 134, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 282, 136, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 468, 139, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 582, 141, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 120, 127, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 212, 145, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 610, 149, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 338, 139, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 511, 144, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 588, 250, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 278, 154, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 27, 213, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 584, 237, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 134, 250, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 90, 320, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 310, 247, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 277, 153, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 613, 249, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 302, 158, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 202, 137, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 364, 136, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(32998, 383, 250, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(32998, 115, 250, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 221, 263, 65500, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 35, 214, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 117, 251, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 466, 249, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 350, 248, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 77, 294, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 209, 297, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 280, 293, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 424, 294, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 582, 305, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(1110, 628, 105, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 572, 126, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(32998, 594, 251, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 192, 145, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 215, 145, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 332, 139, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 354, 140, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 377, 140, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 433, 138, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 457, 138, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 481, 138, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 145, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 144, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 537, 144, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 555, 142, 0, 3031));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 233, 145, 0, 3031));
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

