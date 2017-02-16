using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2500 : Room
  {
        public Room2500()
            : base(2500, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 280, 136, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 114, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 537, 133, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 507, 132, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 128, 109, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 296, 131, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 480, 232, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(32815, 117, 219, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 505, 236, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(35720, 98, 205, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 623, 195, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 55, 288, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 447, 218, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 198, 230, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 598, 143, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 392, 136, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 265, 137, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 24, 125, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 609, 134, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 137, 127, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 144, 131, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 468, 136, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 511, 139, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 67, 307, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 122, 283, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(32813, 597, 254, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 135, 207, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 343, 145, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 459, 154, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 377, 152, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 32, 306, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 462, 330, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 598, 256, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 625, 297, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 539, 82, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 369, 91, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 15, 109, 4, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 10, 116, 4, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(210, 183, 149, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(214, 128, 148, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(215, 511, 151, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(32979, 669, 195, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(32985, 78, 118, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(33015, 534, 186, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(236, 24, 105, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(211, 270, 150, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 367, 150, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(32978, 434, 151, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 114, 221, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 602, 281, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 549, 282, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 483, 237, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 317, 149, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 308, 173, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 328, 172, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 638, 234, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 644, 253, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 645, 272, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 642, 195, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 640, 179, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 2, 109, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65535, 92, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65534, 123, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65533, 140, 0, 2500));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65529, 156, 0, 2500));
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

