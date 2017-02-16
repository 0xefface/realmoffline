using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2507 : Room
  {
        public Room2507()
            : base(2507, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(35511, 573, 134, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 330, 127, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 440, 139, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 632, 140, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 127, 124, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 575, 137, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 247, 131, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 355, 137, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 273, 133, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 65, 141, 24, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 29, 124, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 127, 283, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 532, 302, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 118, 258, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 103, 259, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 7, 127, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 522, 212, 65443, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 30, 193, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 41, 263, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 9, 222, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 195, 194, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 24, 262, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 513, 298, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 576, 190, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 264, 185, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 321, 181, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 53, 138, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 502, 163, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 566, 178, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 614, 176, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 260, 353, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 202, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 10, 211, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 335, 103, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 142, 110, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 588, 191, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 198, 123, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 238, 298, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 200, 198, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(238, 194, 120, 11, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(33015, 235, 134, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(213, 292, 141, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(210, 341, 142, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(221, 424, 160, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(215, 411, 142, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(214, 468, 192, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 556, 191, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(210, 674, 193, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 408, 221, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 390, 185, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 454, 180, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 173, 104, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 176, 50, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 173, 65, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 173, 84, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 639, 229, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 646, 250, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 646, 269, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 641, 192, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 644, 171, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 303, 123, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 281, 124, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 260, 124, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 244, 121, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 226, 118, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 207, 115, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 152, 115, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 133, 116, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 98, 124, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 326, 136, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 350, 136, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 136, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 414, 138, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 436, 138, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 137, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 599, 140, 0, 2507));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 624, 139, 0, 2507));
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

