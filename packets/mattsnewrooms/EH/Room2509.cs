using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2509 : Room
  {
        public Room2509()
            : base(2509, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 279, 128, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 463, 142, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 343, 139, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 415, 145, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 535, 137, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 561, 245, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 418, 250, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 588, 257, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 570, 258, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 392, 233, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 65, 202, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 134, 239, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 386, 231, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 176, 209, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(32813, 38, 205, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 149, 292, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 41, 239, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 423, 298, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 273, 132, 20, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 403, 253, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 140, 245, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 263, 185, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 214, 216, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(32878, 33, 212, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(210, 33, 151, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(211, 121, 152, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 210, 152, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 310, 152, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(209, 265, 152, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 286, 248, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 271, 136, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 265, 147, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 268, 142, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(214, 456, 196, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(216, 428, 184, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(210, 549, 197, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(219, 403, 162, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(211, 638, 198, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 165, 164, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 635, 235, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 645, 254, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 645, 269, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 645, 290, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 637, 197, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 644, 177, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 645, 166, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65532, 175, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65532, 197, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65530, 213, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65528, 236, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65534, 145, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65533, 132, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 166, 139, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 138, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 201, 138, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 217, 138, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 317, 138, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 336, 137, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 359, 138, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 142, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 484, 141, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 522, 137, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 145, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 624, 143, 0, 2509));
          this.AddRoomDecoration(RoomDecoration.FromCode(32878, 311, 178, 0, 2509));
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

