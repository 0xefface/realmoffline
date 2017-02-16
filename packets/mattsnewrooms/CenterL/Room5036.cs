using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5036 : Room
  {
        public Room5036()
            : base(5036, "Duach's Grotto")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 562, 225, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 71, 78, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 39, 95, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 226, 69, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 132, 114, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32969, 68, 160, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 69, 134, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 269, 101, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 153, 76, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 230, 232, 65496, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 426, 267, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 68, 163, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(33018, 178, 167, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 114, 155, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 82, 276, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 254, 137, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32896, 17, 157, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 162, 161, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 482, 266, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(201, 159, 155, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 562, 267, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(200, 56, 166, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32968, 185, 165, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 177, 170, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 44, 106, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 581, 106, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 90, 117, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 4, 325, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 619, 103, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 559, 100, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 501, 96, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 205, 140, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 164, 136, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 116, 129, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 61, 171, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 125, 129, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 449, 237, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 128, 203, 65496, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 244, 242, 65496, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 290, 198, 65496, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 504, 222, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 569, 187, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 598, 172, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 540, 188, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 604, 105, 65506, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 609, 324, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32828, 83, 329, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 628, 236, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32968, 601, 293, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 556, 330, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(201, 621, 268, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(200, 38, 306, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 609, 306, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 27, 327, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 292, 242, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(2749, 453, 82, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 545, 50, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 608, 91, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 624, 49, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 178, 39, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 39, 44, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 87, 156, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 212, 134, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 585, 103, 65506, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 561, 51, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 615, 83, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 271, 130, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 578, 76, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 586, 117, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 226, 122, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 505, 345, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 113, 345, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 590, 85, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 29, 161, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 47, 166, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 70, 167, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 92, 167, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 111, 167, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 134, 167, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 220, 142, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 220, 158, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 180, 167, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 157, 167, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 204, 167, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 215, 163, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 8, 161, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 233, 122, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 233, 103, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 239, 88, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 238, 66, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 237, 49, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 237, 28, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 237, 12, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(131, 541, 118, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(132, 208, 305, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(136, 238, 155, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 505, 93, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 16, 153, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 63, 132, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 140, 132, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 78, 129, 0, 5036));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 43, 145, 0, 5036));
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

