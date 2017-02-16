using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3026 : Room
  {
        public Room3026()
            : base(3026, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 139, 135, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 152, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 200, 156, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 237, 143, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 389, 139, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 552, 135, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 208, 251, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 40, 208, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 146, 236, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 599, 262, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 477, 132, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 414, 131, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 13, 128, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 556, 348, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 109, 137, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 308, 247, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 144, 247, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 309, 261, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 37, 214, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 213, 270, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 428, 212, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 15, 143, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 81, 143, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 353, 134, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 557, 143, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 627, 259, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 505, 131, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 403, 265, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 464, 181, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 265, 141, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 70, 140, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 115, 139, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 245, 142, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 325, 139, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 344, 140, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 366, 139, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 389, 138, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 412, 138, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 434, 138, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 138, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 476, 138, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 7, 125, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 137, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 381, 131, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 405, 131, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 426, 131, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 448, 132, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 483, 132, 0, 3026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 224, 142, 0, 3026));
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

