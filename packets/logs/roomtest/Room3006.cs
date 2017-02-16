using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3006 : Room
  {
        public Room3006()
            : base(3006, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 99, 123, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 318, 139, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 175, 141, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 152, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 252, 140, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 115, 141, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 384, 151, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 511, 150, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 63, 131, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 446, 212, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 376, 249, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 545, 329, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 448, 216, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 362, 263, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(190, 48, 143, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 65449, 141, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 65526, 212, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 56, 107, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 56, 126, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 47, 139, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 35, 163, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 17, 177, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 65524, 557, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 44, 150, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(191, 8, 192, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 30, 175, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 56, 99, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 92, 142, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 120, 142, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 146, 141, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 171, 142, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 197, 142, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 237, 140, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 251, 140, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 277, 139, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 312, 139, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 337, 141, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 404, 151, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 489, 149, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 510, 149, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 531, 150, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 572, 151, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 595, 152, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 588, 142, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 605, 143, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 625, 143, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 74, 130, 0, 3006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 26, 171, 0, 3006));
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

