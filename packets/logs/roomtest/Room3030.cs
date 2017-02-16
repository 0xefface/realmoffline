using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3030 : Room
  {
        public Room3030()
            : base(3030, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 195, 127, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 334, 144, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 203, 140, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 152, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 390, 147, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 602, 157, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 462, 146, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 532, 144, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 116, 139, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 301, 320, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 424, 223, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 405, 263, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 310, 261, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 241, 217, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 391, 222, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 432, 218, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 270, 147, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 515, 136, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 596, 320, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(190, 53, 143, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(196, 52, 142, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 102, 214, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 351, 323, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 323, 259, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 292, 263, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 210, 315, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 65525, 269, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 174, 266, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 204, 268, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 517, 281, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(191, 5, 194, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 78, 241, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 305, 218, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(189, 65533, 258, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(1110, 223, 213, 18, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(32997, 500, 226, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 610, 220, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 11, 208, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(110, 22, 209, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65527, 264, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65529, 277, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65530, 300, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65530, 311, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 81, 103, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 73, 125, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 57, 145, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 43, 166, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 26, 187, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 13, 208, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65533, 253, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 105, 139, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 133, 140, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 163, 139, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 195, 140, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 221, 140, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 456, 146, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 485, 145, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 513, 144, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 537, 144, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 563, 143, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 567, 152, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 581, 158, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 613, 156, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 26, 202, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 38, 179, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 52, 158, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 69, 139, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 80, 117, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 17, 202, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 56, 150, 0, 3030));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 7, 262, 0, 3030));
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

