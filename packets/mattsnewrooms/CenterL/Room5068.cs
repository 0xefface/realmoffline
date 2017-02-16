using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5068 : Room
  {
        public Room5068()
            : base(5068, "Leinster")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.Left;
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 455, 58, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 449, 38, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 454, 79, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 456, 100, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 460, 121, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 460, 141, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 198, 145, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 462, 148, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 150, 183, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 202, 208, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 460, 211, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 458, 222, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 460, 239, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 460, 256, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 463, 276, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 465, 294, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 467, 309, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 473, 326, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 26, 311, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 630, 214, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 626, 144, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 578, 210, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 29, 251, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 504, 209, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 240, 229, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 235, 331, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 521, 148, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 571, 146, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 58, 207, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 548, 209, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 240, 140, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 242, 209, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 240, 246, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 237, 261, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 233, 280, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 230, 296, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 231, 313, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 240, 128, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 240, 114, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 240, 97, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 245, 82, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 247, 66, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 247, 53, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 254, 40, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 106, 37, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 110, 97, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 106, 70, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 101, 14, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 101, 214, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 114, 188, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 109, 263, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 79, 247, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 633, 2, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 583, 46, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 607, 77, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 94, 129, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 95, 160, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 590, 185, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 632, 217, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 621, 271, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 608, 78, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 613, 293, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 37, 108, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 609, 335, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 610, 41, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 614, 133, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 38, 72, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 77, 345, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 81, 90, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 71, 140, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 105, 67, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 26, 175, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 617, 115, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 591, 119, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 515, 120, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 570, 118, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 547, 121, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 194, 101, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 188, 278, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 557, 211, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 528, 210, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 503, 211, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 509, 223, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 509, 238, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 274, 172, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 280, 166, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 275, 159, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 175, 121, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 191, 111, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 266, 152, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 164, 208, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 189, 212, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 194, 228, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 192, 246, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 190, 261, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 150, 125, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 163, 200, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 512, 107, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 513, 254, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 157, 154, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 152, 169, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 252, 178, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 231, 172, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 247, 151, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 223, 154, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 206, 157, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 201, 170, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 194, 165, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 125, 202, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 187, 292, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 187, 308, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 182, 325, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 112, 193, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 105, 184, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 102, 170, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 108, 154, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 119, 140, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 130, 131, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 193, 90, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 197, 76, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 197, 65, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 200, 53, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 200, 42, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 208, 31, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 511, 95, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 504, 81, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 499, 68, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 501, 54, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 496, 41, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 493, 28, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 517, 269, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 519, 282, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 522, 299, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 525, 317, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 132, 497, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 519, 501, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 515, 146, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 624, 504, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 611, 146, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 145, 207, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 140, 135, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 191, 272, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 126, 287, 0, 5068));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 37, 314, 0, 5068));
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

