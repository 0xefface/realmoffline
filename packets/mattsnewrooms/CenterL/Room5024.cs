using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5024 : Room
  {
        public Room5024()
            : base(5024, "Music Cart")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 110, 10, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2539, 560, 98, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 246, 98, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(134, 469, 281, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2539, 57, 93, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 21, 102, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 446, 99, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 24, 218, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 594, 238, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 189, 206, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 626, 104, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2539, 514, 99, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 525, 333, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 138, 335, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2539, 101, 93, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2539, 144, 95, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 526, 105, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2539, 606, 98, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 585, 127, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 111, 101, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 631, 103, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 52, 100, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 12, 123, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 200, 269, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(200, 30, 283, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(201, 602, 267, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 369, 175, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32969, 14, 266, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32904, 620, 262, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 279, 178, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(134, 32, 298, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2539, 470, 98, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2539, 427, 97, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 355, 201, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 521, 117, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2539, 188, 96, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(136, 159, 100, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 63, 104, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(138, 468, 102, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(131, 613, 215, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2539, 230, 97, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 429, 229, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(132, 159, 307, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 127, 155, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 517, 153, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 144, 109, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 495, 109, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 353, 21, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 339, 283, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 342, 230, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 323, 105, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 65525, 138, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 664, 138, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 521, 102, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 339, 191, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32881, 306, 192, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 117, 100, 0, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 549, 2, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 319, 10, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 444, 7, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 80, 39, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 556, 34, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 52, 79, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 203, 35, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 454, 60, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 442, 37, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 530, 33, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 214, 50, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 193, 82, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 533, 74, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 108, 106, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 329, 111, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 329, 129, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 334, 146, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 541, 105, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 557, 135, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 64, 147, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 273, 125, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 568, 174, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 497, 163, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 594, 163, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 145, 171, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 542, 209, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 65526, 176, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 88, 188, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 82, 269, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 128, 232, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 469, 267, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 566, 263, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 264, 229, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 427, 186, 65526, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2158, 332, 176, 50, 5024));
          this.AddRoomDecoration(RoomDecoration.FromCode(85, 321, 175, 0, 5024));
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

