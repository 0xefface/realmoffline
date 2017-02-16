using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3034 : Room
  {
        public Room3034()
            : base(3034, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 77, 124, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 243, 133, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 462, 127, 14, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 145, 142, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 152, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 200, 156, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 253, 161, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 608, 161, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 525, 150, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 545, 221, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 475, 215, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 524, 225, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 248, 309, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 410, 105, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 252, 113, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 41, 254, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 325, 247, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 239, 298, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 364, 130, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 368, 112, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 370, 153, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 366, 155, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 355, 150, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 335, 104, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 330, 226, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 77, 257, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 37, 326, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 293, 260, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 47, 312, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 157, 309, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 221, 309, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 266, 304, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 32, 256, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 586, 325, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 28, 207, 9, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 476, 219, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 403, 235, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 582, 230, 33, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 231, 298, 7, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 151, 233, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 536, 257, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 596, 219, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 455, 118, 36, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 413, 130, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 393, 172, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 236, 257, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 449, 113, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 403, 106, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 112, 141, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 136, 141, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 141, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 141, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 192, 155, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 215, 155, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 266, 160, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 293, 139, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 340, 139, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 364, 139, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 379, 128, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 357, 129, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 98, 132, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 74, 132, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 502, 150, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 581, 160, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 161, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 161, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 585, 151, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 609, 151, 0, 3034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 526, 150, 0, 3034));
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

