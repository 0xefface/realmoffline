using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3023 : Room
  {
        public Room3023()
            : base(3023, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 133, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 278, 141, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 448, 133, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 630, 133, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 145, 142, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 152, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 263, 142, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 207, 142, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 526, 139, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 78, 133, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 376, 248, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 497, 320, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 441, 220, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 390, 251, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 582, 177, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 505, 221, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 307, 246, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 30, 209, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 565, 201, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 414, 219, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 480, 256, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 522, 228, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 574, 205, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 618, 213, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 566, 199, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 575, 178, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 540, 275, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 581, 95, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 380, 120, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 354, 167, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 408, 168, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 136, 132, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 13, 210, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 105, 141, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 128, 141, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 151, 141, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 175, 141, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 197, 141, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 220, 141, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 244, 141, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 141, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 469, 131, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 447, 132, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 341, 164, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 535, 136, 0, 3023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 596, 149, 0, 3023));
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

