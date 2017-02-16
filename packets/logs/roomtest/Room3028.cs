using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3028 : Room
  {
        public Room3028()
            : base(3028, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 325, 136, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 488, 116, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 601, 138, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 148, 136, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 567, 144, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 26, 138, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 422, 137, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 86, 142, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 393, 139, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 519, 141, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 570, 207, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 249, 257, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 259, 212, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 580, 214, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 40, 208, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 144, 236, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 221, 223, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 610, 255, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 284, 209, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 73, 214, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 230, 268, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 612, 274, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 392, 224, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(33000, 349, 112, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 447, 280, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 118, 245, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 350, 135, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 343, 169, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 448, 271, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 141, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 141, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 374, 139, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 398, 138, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 419, 138, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 442, 138, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 458, 135, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 491, 141, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 513, 141, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 537, 141, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 182, 135, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 629, 135, 0, 3028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 109, 141, 0, 3028));
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

