using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3040 : Room
  {
        public Room3040()
            : base(3040, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 585, 134, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 276, 132, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 432, 120, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 529, 134, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 184, 141, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 95, 125, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 309, 131, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 25, 139, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 251, 135, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 76, 269, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32889, 65502, 329, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 297, 249, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 441, 222, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 633, 258, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 92, 144, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 332, 137, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 309, 211, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 296, 257, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 335, 197, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 194, 236, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(33002, 386, 131, 20, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 128, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 635, 290, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 442, 235, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 389, 151, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 390, 118, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 362, 222, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 378, 236, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 525, 276, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 412, 258, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 577, 201, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 254, 227, 11, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 128, 251, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 263, 195, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 318, 257, 15, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 617, 272, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 548, 254, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 525, 225, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 554, 235, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 211, 227, 65527, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 218, 208, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 258, 266, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 545, 325, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 391, 165, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 547, 274, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 58, 143, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 81, 143, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 104, 143, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 122, 143, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 155, 139, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 139, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 214, 140, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 8, 138, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 31, 137, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 364, 137, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 409, 119, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 485, 133, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 507, 133, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 132, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 132, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 572, 133, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 131, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 483, 126, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 464, 127, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 217, 131, 0, 3040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 230, 131, 0, 3040));
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

