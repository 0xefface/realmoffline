using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2508 : Room
  {
        public Room2508()
            : base(2508, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 284, 139, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 489, 139, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 145, 137, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 152, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 186, 144, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 343, 139, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 424, 145, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 489, 148, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 547, 142, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 246, 219, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 96, 186, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 606, 208, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 564, 215, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 63, 271, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(35720, 11, 249, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 85, 270, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 51, 266, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 223, 222, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 37, 257, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 254, 223, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 345, 315, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 58, 321, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 513, 315, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 587, 262, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 609, 209, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(211, 56, 194, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(32982, 156, 194, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(32983, 189, 152, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(32979, 262, 154, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 351, 152, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(213, 415, 154, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(210, 474, 154, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(211, 556, 155, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 638, 155, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(61, 511, 181, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(110, 501, 184, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 209, 195, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 136, 183, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 390, 165, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 438, 166, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 642, 185, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 642, 204, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 645, 221, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 645, 239, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 645, 154, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 641, 141, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 1, 192, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65531, 172, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65531, 230, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65530, 249, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65529, 268, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 136, 136, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 158, 134, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 184, 143, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 208, 143, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 317, 138, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 339, 138, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 363, 138, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 407, 145, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 431, 144, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 470, 148, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 493, 147, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 502, 147, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 141, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 553, 140, 0, 2508));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 573, 150, 0, 2508));
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

