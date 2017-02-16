using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5052 : Room
  {
        public Room5052()
            : base(5052, "The Temple Gardens")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.Down;
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 413, 197, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 304, 129, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 530, 341, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 94, 231, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 134, 302, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 428, 65, 65496, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 240, 203, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(32997, 540, 225, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 178, 342, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 274, 340, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 319, 294, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 465, 342, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 604, 340, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 370, 339, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 499, 302, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 90, 342, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 318, 36, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 338, 25, 65531, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 591, 214, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 546, 213, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 617, 212, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 569, 215, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 398, 180, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 399, 216, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 398, 129, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35529, 239, 128, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35527, 240, 182, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35530, 187, 217, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35527, 238, 215, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 425, 216, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35529, 210, 215, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 448, 215, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35527, 165, 215, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35528, 140, 217, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35530, 114, 218, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35529, 92, 218, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 44, 220, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35527, 24, 219, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35530, 45, 219, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 475, 217, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 522, 215, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 496, 216, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 273, 55, 65496, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 337, 38, 65496, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 294, 112, 65496, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 124, 151, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35482, 585, 195, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35482, 519, 146, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35481, 569, 130, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 47, 156, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(33000, 313, 82, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 402, 86, 65496, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 198, 79, 65496, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 537, 217, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 92, 216, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 110, 165, 65496, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 76, 210, 65496, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 478, 190, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 172, 188, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 572, 163, 65496, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 347, 179, 65496, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 270, 189, 65496, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 418, 195, 65496, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 558, 203, 65496, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 25, 342, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 216, 218, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 125, 219, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 49, 220, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 439, 216, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 516, 217, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 602, 216, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 212, 93, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35482, 424, 96, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 177, 217, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 200, 161, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35481, 447, 161, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35482, 470, 216, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 604, 213, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35481, 44, 218, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 50, 214, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 399, 114, 65496, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 277, 30, 65511, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(35527, 240, 80, 0, 5052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 398, 82, 0, 5052));
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

