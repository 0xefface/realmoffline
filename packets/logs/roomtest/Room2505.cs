using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2505 : Room
  {
        public Room2505()
            : base(2505, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(35511, 280, 136, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 114, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 537, 133, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 507, 132, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 125, 131, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 92, 133, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 296, 131, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 35, 306, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 594, 280, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 212, 216, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(35720, 328, 247, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 629, 144, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 37, 321, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 382, 223, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 192, 229, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 598, 143, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 392, 136, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 332, 137, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 140, 137, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 609, 134, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(32920, 242, 140, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 70, 137, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 468, 136, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 511, 139, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 8, 134, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(32813, 128, 248, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 515, 249, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 541, 91, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 316, 145, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 471, 148, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 508, 157, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 385, 144, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 432, 165, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 549, 148, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 33, 141, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 602, 147, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 426, 209, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 346, 293, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 139, 251, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 112, 325, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 333, 328, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 595, 298, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 606, 281, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 439, 281, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 426, 210, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 383, 154, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 89, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 466, 204, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 312, 224, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 138, 251, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 225, 327, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 39, 307, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 546, 254, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 606, 264, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 508, 250, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 588, 205, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 513, 217, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 386, 243, 0, 2505));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 626, 230, 0, 2505));
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

