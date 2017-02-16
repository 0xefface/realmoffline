using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5053 : Room
  {
        public Room5053()
            : base(5053, "Leinster")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 230, 114, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(35522, 89, 234, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(35521, 67, 235, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 252, 128, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 308, 153, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 421, 104, 65496, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(35520, 46, 237, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2757, 242, 91, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 68, 255, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 68, 180, 65496, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 162, 168, 65496, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(35519, 25, 242, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 249, 130, 65496, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 69, 185, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 332, 72, 65496, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 278, 34, 65496, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 233, 105, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 249, 145, 65496, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 381, 250, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 243, 80, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 223, 126, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 426, 57, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 478, 45, 65496, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 530, 72, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 571, 38, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 438, 20, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 417, 75, 65496, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 621, 83, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 104, 101, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 35, 234, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 117, 210, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 44, 169, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 182, 172, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 392, 208, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 316, 216, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 202, 201, 65496, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 399, 284, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 460, 231, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 102, 220, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 92, 237, 65496, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 546, 278, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 259, 244, 65496, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 450, 11, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 269, 250, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 475, 254, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 561, 6, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 377, 169, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 215, 217, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(35519, 109, 229, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(35520, 128, 219, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 415, 181, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(35521, 145, 214, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(35522, 164, 210, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(35520, 177, 203, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(35521, 191, 193, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(35522, 203, 186, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(35520, 213, 172, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(35522, 226, 161, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2758, 214, 140, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 357, 7, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 210, 40, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 189, 216, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 344, 73, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(33000, 346, 20, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 178, 144, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 222, 100, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 607, 109, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 583, 79, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 541, 74, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(35521, 231, 145, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 235, 155, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 29, 245, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 90, 236, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 152, 217, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 190, 194, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 217, 275, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 521, 123, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 434, 160, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 474, 105, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 554, 115, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 546, 119, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 496, 337, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 68, 335, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 236, 292, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 387, 72, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 34, 353, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 91, 353, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 161, 330, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 325, 334, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 594, 350, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 506, 349, 0, 5053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 401, 347, 0, 5053));
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

