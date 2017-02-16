using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3036 : Room
  {
        public Room3036()
            : base(3036, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.Left;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 195, 126, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 175, 141, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 152, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 247, 140, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 149, 138, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 384, 151, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 525, 150, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 376, 251, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 545, 329, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 449, 229, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 390, 253, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(190, 51, 144, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 77, 228, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(33000, 80, 104, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(196, 49, 143, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 377, 252, 12, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 91, 169, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 76, 126, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 13, 205, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 67, 104, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 59, 126, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 45, 147, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 31, 167, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 16, 189, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 2, 212, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 65534, 228, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 27, 180, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 42, 162, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 55, 138, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 66, 114, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 125, 139, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 147, 140, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 175, 140, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 205, 140, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 231, 140, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 259, 140, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 282, 139, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 310, 139, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 331, 140, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 352, 139, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 385, 151, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 407, 152, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 485, 139, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 415, 137, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 507, 150, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 530, 150, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 570, 152, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 589, 152, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 588, 142, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 614, 142, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 627, 143, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 65523, 318, 0, 3036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 45, 170, 0, 3036));
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

