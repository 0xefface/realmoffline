using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3012 : Room
  {
        public Room3012()
            : base(3012, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 166, 128, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 573, 134, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 145, 142, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 152, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 210, 142, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 381, 139, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 611, 164, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 525, 150, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 86, 142, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 134, 312, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 478, 232, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 283, 145, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 96, 346, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 162, 222, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 482, 5, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 379, 252, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(32816, 223, 234, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 607, 258, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 80, 207, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 45, 209, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 163, 257, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 306, 262, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 543, 260, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 268, 358, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 552, 292, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 290, 301, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 433, 297, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 8, 274, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 266, 317, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 428, 323, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 450, 245, 11, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(190, 29, 141, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(191, 11, 212, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(196, 29, 140, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65530, 321, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 126, 232, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(1110, 26, 212, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 214, 238, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(32991, 162, 227, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(32991, 605, 261, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65528, 241, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65528, 261, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65528, 283, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65529, 305, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 46, 114, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 39, 137, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 31, 158, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 17, 181, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 14, 202, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65530, 243, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 28, 172, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 38, 148, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 294, 138, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 108, 142, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 137, 141, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 169, 141, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 246, 145, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 271, 146, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 310, 146, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 350, 138, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 375, 138, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 395, 139, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 453, 139, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 481, 140, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 508, 150, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 534, 150, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 564, 151, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 588, 164, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 625, 165, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 591, 152, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 578, 132, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(189, 65528, 249, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65530, 267, 0, 3012));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 23, 203, 0, 3012));
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

