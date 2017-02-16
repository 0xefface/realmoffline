using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6914 : Room
  {
        public Room6914()
            : base(6914, "Valhalla Training Ground")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.DownLeftRight;
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 614, 215, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 580, 219, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 547, 120, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1591, 402, 201, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 604, 179, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 222, 103, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 22, 307, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 387, 99, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 310, 290, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 320, 107, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 348, 104, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 20, 181, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 51, 120, 65496, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1590, 287, 195, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 617, 110, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 105, 121, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 613, 177, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(180, 327, 191, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1592, 337, 197, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 88, 312, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 399, 102, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 594, 136, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 503, 120, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32968, 613, 304, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(34361, 267, 230, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 620, 222, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 490, 112, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 382, 127, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 137, 122, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 574, 101, 65496, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 362, 326, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32958, 603, 117, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 155, 118, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 350, 121, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 589, 93, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(2539, 323, 111, 65526, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 544, 313, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 574, 147, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 57, 316, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(190, 46, 121, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 50, 145, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 70, 148, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 456, 316, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 603, 314, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 107, 114, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 525, 116, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 167, 198, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(195, 324, 94, 65521, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 506, 110, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 381, 127, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 251, 188, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 323, 109, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1593, 363, 229, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1590, 480, 208, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(34359, 510, 250, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1591, 113, 232, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1591, 148, 259, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1594, 391, 207, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1591, 128, 251, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1592, 289, 275, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(34362, 242, 210, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1592, 238, 269, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(34362, 281, 199, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(34359, 509, 244, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1590, 148, 209, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1592, 349, 272, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1592, 503, 253, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 323, 137, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 322, 130, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 253, 194, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(33003, 391, 193, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 333, 160, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 312, 159, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 311, 158, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1590, 233, 196, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 344, 187, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 302, 178, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1590, 416, 265, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(1594, 329, 196, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 212, 102, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 255, 98, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 487, 102, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 450, 112, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 614, 162, 65476, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 587, 119, 65496, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 14, 133, 65496, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(241, 464, 20, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(246, 160, 22, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 521, 83, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 310, 290, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 283, 120, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 310, 290, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 310, 290, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 630, 173, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 446, 104, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 242, 110, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 142, 108, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 82, 119, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 52, 117, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 259, 126, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 261, 126, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 24, 209, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 33, 210, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 310, 290, 65516, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 165, 97, 65506, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 521, 134, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 49, 148, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 77, 148, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 97, 148, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 247, 127, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 271, 127, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 377, 129, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 400, 129, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 553, 147, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 578, 147, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 605, 147, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 54, 309, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 468, 197, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 14, 317, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 387, 187, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 615, 313, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(201, 595, 312, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 134, 304, 65526, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 651, 322, 0, 6914));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 2, 312, 0, 6914));
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

