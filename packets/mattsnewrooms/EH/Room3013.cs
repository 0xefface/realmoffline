using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3013 : Room
  {
        public Room3013()
            : base(3013, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 477, 139, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 102, 142, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 35, 150, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 333, 146, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 551, 148, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 29, 135, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 260, 262, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 182, 311, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 305, 199, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 207, 224, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 420, 199, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 45, 268, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 256, 357, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 266, 222, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 256, 355, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 124, 190, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 122, 202, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 549, 211, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 433, 207, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 196, 199, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 403, 203, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 331, 220, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 418, 200, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 517, 236, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 594, 235, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 0, 258, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 174, 188, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 311, 247, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 615, 234, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 67, 326, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 564, 264, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 446, 201, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 167, 244, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 260, 255, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 294, 259, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 211, 228, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 27, 216, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 97, 218, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 170, 199, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 162, 203, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 129, 209, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 333, 145, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 354, 145, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 372, 145, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 136, 141, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 112, 141, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 88, 141, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 22, 148, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 45, 148, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 447, 138, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 469, 139, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 138, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 509, 138, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 533, 146, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 556, 146, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 579, 146, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 601, 144, 0, 3013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 135, 0, 3013));
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

