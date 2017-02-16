using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5022 : Room
  {
        public Room5022()
            : base(5022, "Despothes' Grove")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2259, 309, 162, 13, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 256, 321, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 177, 73, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 202, 137, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 132, 33, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 172, 92, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 320, 31, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 314, 140, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 272, 65, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 522, 260, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 42, 221, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 234, 138, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 430, 149, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 348, 130, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 69, 185, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 372, 143, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 255, 101, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 245, 134, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32889, 359, 134, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 384, 63, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 264, 15, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 634, 387, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 447, 58, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 426, 88, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 233, 228, 65486, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 82, 276, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 555, 285, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 396, 121, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 166, 19, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(121, 257, 122, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 309, 142, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 564, 225, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 617, 195, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(200, 378, 151, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32968, 237, 152, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 287, 238, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 208, 237, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 26, 247, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 467, 234, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 572, 233, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 413, 235, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 213, 240, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(132, 223, 154, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32900, 397, 160, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 82, 380, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(35481, 230, 91, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(35481, 149, 94, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 397, 98, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 458, 95, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 61, 335, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 581, 335, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 308, 342, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 18, 322, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 639, 322, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 306, 269, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 492, 260, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 139, 262, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 535, 226, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 83, 237, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 367, 321, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 318, 320, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 414, 228, 65486, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 309, 152, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 197, 151, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 378, 155, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 439, 143, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 422, 154, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 401, 155, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 243, 151, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 221, 151, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 333, 152, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 286, 151, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 264, 151, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 356, 155, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 177, 144, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 170, 125, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 448, 130, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 165, 106, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 157, 87, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 155, 68, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 154, 51, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 154, 31, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 154, 13, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 451, 111, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 452, 91, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 455, 73, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 459, 54, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 458, 37, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 459, 19, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 303, 140, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 495, 27, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 266, 139, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 226, 323, 0, 5022));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 400, 324, 0, 5022));
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

