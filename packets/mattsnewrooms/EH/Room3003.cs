using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3003 : Room
  {
        public Room3003()
            : base(3003, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 280, 136, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 114, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 543, 133, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 482, 133, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 125, 131, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 92, 133, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 296, 131, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 57, 289, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 447, 218, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 190, 232, 14, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 598, 143, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 392, 136, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 332, 137, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 140, 137, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 609, 134, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32920, 242, 140, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 70, 137, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 468, 136, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 511, 139, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 8, 134, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(121, 65519, 349, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 134, 260, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 199, 228, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 509, 240, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 614, 210, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 432, 222, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 310, 251, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 406, 225, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 302, 209, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 246, 352, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 304, 260, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 120, 266, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 426, 223, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 508, 249, 31, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 607, 214, 0, 3003));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 195, 231, 0, 3003));
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

