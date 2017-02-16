using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5083 : Room
  {
        public Room5083()
            : base(5083, "Leinster")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.Down;
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 133, 6, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(35514, 254, 45, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(2747, 373, 43, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(2748, 65505, 43, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 487, 4, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 476, 35, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 134, 34, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(2748, 498, 43, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 492, 176, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 118, 189, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 612, 272, 10, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 493, 230, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 121, 234, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 524, 201, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 94, 203, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 486, 89, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 120, 76, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(25, 595, 86, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 91, 65, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 596, 81, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 455, 188, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 324, 344, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 517, 155, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 114, 173, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 93, 171, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 545, 164, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 135, 30, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 208, 89, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 134, 302, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 273, 83, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 269, 158, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 297, 191, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 355, 230, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 393, 105, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 255, 105, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 298, 37, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 103, 147, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32997, 551, 141, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 22, 76, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 617, 91, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 322, 186, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 536, 70, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 107, 65, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 131, 105, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 121, 112, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 174, 114, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 145, 107, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 185, 106, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 163, 114, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 169, 101, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 214, 108, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 188, 114, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 190, 102, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 238, 109, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 100, 111, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 106, 117, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 149, 100, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 165, 116, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 124, 108, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 167, 120, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 163, 93, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 139, 120, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 180, 96, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 182, 116, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 142, 99, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 195, 96, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 211, 118, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 123, 119, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 231, 111, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 222, 102, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 211, 95, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 104, 117, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 121, 100, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 102, 105, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 93, 112, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 244, 137, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 390, 130, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 79, 139, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 536, 134, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 147, 108, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 451, 103, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 467, 107, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 471, 100, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 483, 104, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 480, 107, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 523, 105, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 529, 101, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 438, 100, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 417, 105, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 461, 106, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 455, 99, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 412, 102, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 541, 106, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 441, 110, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 456, 96, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 462, 108, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 515, 108, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 430, 96, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 431, 110, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 453, 92, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 469, 90, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 489, 94, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 503, 95, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 527, 100, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 541, 105, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 532, 110, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 508, 110, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 482, 111, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 459, 110, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 378, 192, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 264, 194, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 225, 209, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 417, 209, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 228, 230, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 427, 229, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 411, 241, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 250, 245, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 295, 255, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 381, 250, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 343, 255, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 379, 206, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 265, 210, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 303, 218, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 283, 202, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 360, 202, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 340, 201, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 293, 223, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 309, 221, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 388, 214, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 377, 220, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 362, 223, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 457, 203, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 186, 205, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 466, 215, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 469, 225, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 465, 234, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 448, 243, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 426, 251, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 404, 254, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 391, 255, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 179, 214, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 183, 221, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 189, 232, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 203, 239, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 213, 246, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 239, 250, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 260, 256, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 283, 256, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 368, 256, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 347, 255, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 299, 255, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 333, 255, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 318, 255, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 193, 197, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(200, 37, 268, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 604, 340, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 514, 343, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 48, 341, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 143, 343, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 238, 345, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 425, 343, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 499, 302, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 319, 294, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 328, 255, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 326, 204, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 227, 244, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 519, 79, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 106, 85, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 209, 237, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 187, 230, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 171, 219, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 169, 201, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 182, 191, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 201, 177, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 229, 175, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 414, 170, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 433, 178, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 451, 184, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 470, 196, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 478, 209, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 477, 218, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 475, 227, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 472, 234, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 459, 240, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 436, 244, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 421, 245, 0, 5083));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 621, 19, 0, 5083));
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

