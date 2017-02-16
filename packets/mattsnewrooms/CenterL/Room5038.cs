using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5038 : Room
  {
        public Room5038()
            : base(5038, "Enid's Alcove")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 214, 208, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 14, 80, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 76, 108, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 372, 100, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 146, 192, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 426, 71, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 93, 120, 65516, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 465, 135, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 158, 302, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 42, 221, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 141, 210, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 68, 148, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 616, 149, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 69, 185, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 153, 134, 65486, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 89, 291, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 408, 142, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 484, 153, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 400, 105, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 620, 151, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 473, 46, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 457, 78, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 502, 108, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 568, 92, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 520, 49, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 578, 47, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 400, 144, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 614, 139, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 532, 178, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 551, 143, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 522, 137, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 387, 134, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 552, 150, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 623, 152, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 304, 238, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 207, 237, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 26, 247, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 446, 155, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 561, 142, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 82, 276, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 563, 273, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 244, 284, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 267, 256, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 408, 216, 65486, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 482, 266, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 487, 132, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 571, 110, 65516, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(35482, 595, 107, 65516, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(35482, 430, 115, 65516, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(35482, 491, 117, 65516, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 576, 132, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 119, 323, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 446, 152, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 611, 148, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 590, 135, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 364, 128, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 388, 151, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 399, 145, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 503, 145, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 511, 152, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 417, 152, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 537, 138, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 585, 151, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 413, 153, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 447, 154, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 452, 153, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 556, 118, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 620, 150, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 35, 321, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 34, 117, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 69, 88, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 23, 319, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 368, 97, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 612, 318, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 566, 327, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 523, 319, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 7, 285, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 390, 287, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 379, 274, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(35515, 133, 92, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 90, 58, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 81, 76, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 100, 93, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 113, 82, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 65, 94, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 140, 94, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 59, 94, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 84, 282, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 47, 279, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 53, 276, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 34, 138, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 27, 130, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 497, 319, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 551, 317, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 110, 263, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 161, 283, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 550, 141, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 547, 137, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 430, 141, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 44, 91, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 452, 133, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 432, 135, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 628, 135, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 102, 162, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 138, 341, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 552, 341, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 628, 151, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 604, 152, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 581, 152, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 558, 152, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 534, 152, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 510, 152, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 487, 152, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 464, 152, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 441, 152, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 419, 152, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 398, 148, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 379, 142, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 366, 128, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 376, 118, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 375, 99, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 373, 86, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 374, 65, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 374, 42, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 375, 23, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 375, 11, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 286, 321, 0, 5038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 461, 319, 0, 5038));
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

