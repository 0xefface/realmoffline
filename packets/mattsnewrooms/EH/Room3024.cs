using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3024 : Room
  {
        public Room3024()
            : base(3024, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.Left;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 235, 133, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 184, 141, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 152, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 264, 146, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 384, 151, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 525, 150, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 153, 136, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 20, 329, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 140, 235, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 607, 211, 14, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 331, 257, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 335, 104, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(196, 52, 138, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(190, 52, 139, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 309, 247, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 614, 257, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 123, 238, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 497, 223, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 51, 236, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(35511, 174, 128, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 4, 222, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 19, 201, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 37, 180, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 37, 161, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 54, 137, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 71, 113, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 73, 105, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 48, 170, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 32, 196, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 16, 213, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 48, 150, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 65, 126, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 153, 143, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 181, 142, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 210, 141, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 242, 148, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 264, 146, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 358, 151, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 383, 151, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 402, 150, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 518, 150, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 544, 150, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 568, 153, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 9, 318, 0, 3024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 48, 139, 0, 3024));
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

