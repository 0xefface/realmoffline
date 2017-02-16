using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2503 : Room
  {
        public Room2503()
            : base(2503, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(35511, 280, 136, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 114, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 543, 133, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 482, 133, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 125, 131, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 92, 133, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 296, 131, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 30, 295, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 446, 222, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(32991, 192, 232, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 556, 142, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 412, 136, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 332, 137, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 140, 137, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 633, 133, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(32920, 266, 138, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 67, 138, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 468, 136, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 531, 137, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 8, 134, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(121, 65519, 349, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 115, 261, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 199, 228, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 507, 301, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 570, 141, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 433, 228, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 347, 265, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 406, 225, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 356, 219, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 246, 352, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 364, 266, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 96, 272, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 401, 234, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 338, 104, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 182, 221, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 564, 170, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 529, 172, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 453, 187, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 470, 184, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 127, 243, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 486, 302, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 535, 238, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 541, 254, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 105, 259, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 366, 255, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 362, 189, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 298, 198, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 56, 277, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 34, 300, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 10, 314, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 491, 181, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 328, 302, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 634, 168, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 512, 177, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 576, 141, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 445, 180, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 520, 171, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 610, 169, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 514, 198, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 342, 264, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 401, 262, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 509, 264, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 266, 233, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 583, 170, 0, 2503));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 558, 139, 0, 2503));
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

