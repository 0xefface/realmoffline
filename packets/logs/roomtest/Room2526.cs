using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2526 : Room
  {
        public Room2526()
            : base(2526, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 93, 128, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(35511, 568, 128, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 299, 129, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 538, 133, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 601, 138, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 117, 132, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 488, 128, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 58, 134, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 362, 138, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 251, 132, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 193, 130, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 429, 224, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 55, 196, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 428, 223, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 382, 147, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 232, 185, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 584, 257, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 120, 129, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 67, 190, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 22, 208, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(35720, 55, 321, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 67, 189, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 309, 246, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 614, 256, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 264, 185, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 321, 181, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 351, 173, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 288, 173, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 553, 196, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 387, 131, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 260, 353, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 7, 211, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 31, 216, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 415, 101, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 489, 116, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 206, 247, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 217, 142, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 453, 130, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 138, 201, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 134, 208, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 112, 217, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 112, 226, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 117, 239, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 326, 262, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 21, 333, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 365, 324, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 381, 325, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 448, 227, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 57, 187, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 83, 187, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(32991, 622, 271, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(32991, 315, 253, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 298, 297, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 328, 303, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 324, 311, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 414, 140, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 459, 92, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 175, 158, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 320, 142, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 96, 131, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 121, 130, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 131, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 178, 128, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 202, 129, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 243, 131, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 360, 136, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 382, 137, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 483, 126, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 132, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 537, 131, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 548, 131, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 579, 138, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 599, 139, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 255, 174, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 241, 173, 0, 2526));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 212, 183, 0, 2526));
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

