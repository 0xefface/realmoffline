using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3002 : Room
  {
        public Room3002()
            : base(3002, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 280, 136, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(3742, 429, 116, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 537, 133, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 507, 132, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 100, 133, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 92, 133, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 296, 130, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 41, 208, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 180, 198, 14, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32992, 529, 209, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 98, 237, 13, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 598, 143, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 432, 141, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 328, 139, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 140, 137, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 609, 134, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 242, 140, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 70, 137, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 478, 137, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 511, 139, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 8, 134, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 91, 261, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 83, 232, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(121, 617, 326, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 517, 198, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 442, 220, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 309, 246, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 129, 234, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 198, 184, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 110, 264, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 217, 299, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 282, 258, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 347, 230, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 363, 214, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 346, 236, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 240, 284, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 359, 223, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 384, 139, 20, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 369, 187, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 377, 157, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 362, 197, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 375, 174, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 312, 248, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 377, 145, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 529, 207, 14, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 56, 217, 16, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 366, 206, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 381, 141, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 235, 256, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(110, 36, 211, 65531, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 183, 188, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32881, 437, 227, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 107, 237, 0, 3002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32991, 516, 199, 0, 3002));
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

