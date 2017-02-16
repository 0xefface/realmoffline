using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2516 : Room
  {
        public Room2516()
            : base(2516, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 103, 127, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(35511, 573, 132, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 334, 131, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 474, 137, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 586, 138, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 315, 142, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 625, 140, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 276, 136, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 372, 138, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 189, 134, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 81, 130, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 349, 258, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 73, 300, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 346, 257, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 78, 243, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 119, 253, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 62, 309, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 42, 205, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 132, 231, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 81, 291, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 614, 330, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 35, 209, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 51, 299, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 107, 255, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 259, 203, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 604, 263, 17, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 536, 270, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 488, 265, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 507, 286, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 436, 263, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 260, 353, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 29, 212, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 118, 237, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 283, 147, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 202, 160, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(203, 247, 119, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(32985, 117, 128, 15, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(32974, 147, 147, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(214, 156, 200, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(211, 272, 204, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(247, 579, 194, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(32987, 631, 176, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 414, 203, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(32895, 636, 336, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 486, 210, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 490, 194, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 491, 239, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 494, 238, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 193, 218, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 192, 228, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 344, 220, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 345, 232, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 631, 202, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 640, 218, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 641, 236, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 642, 255, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 634, 175, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 643, 158, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 223, 124, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 205, 125, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 184, 125, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 164, 124, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 145, 128, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 122, 125, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 104, 120, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 87, 123, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 268, 134, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 290, 134, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 294, 142, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 318, 141, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 369, 138, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 393, 138, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 451, 137, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 475, 136, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 498, 136, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 533, 130, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 561, 137, 0, 2516));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 585, 137, 0, 2516));
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

