using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1005 : Room
  {
        public Room1005()
            : base(1005, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(171, 236, 106, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 329, 200, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 30, 114, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 13, 114, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 54, 280, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 203, 106, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 63, 107, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 187, 107, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 275, 108, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 103, 107, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 336, 108, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 73, 105, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 175, 105, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 133, 103, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 229, 104, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 272, 110, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 313, 109, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 376, 114, 7, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 316, 208, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 634, 265, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 614, 278, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 550, 296, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 627, 138, 65526, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 617, 130, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 372, 113, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 130, 104, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 623, 150, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 497, 132, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 140, 107, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 21, 120, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 305, 212, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 582, 287, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 600, 151, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 585, 147, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 370, 203, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 353, 206, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 629, 159, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 616, 126, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 616, 125, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 663, 258, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 373, 208, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 24, 234, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 530, 274, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 512, 127, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 534, 127, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 558, 127, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 581, 127, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 127, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 638, 127, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 451, 103, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 465, 236, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 453, 182, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 445, 150, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 440, 235, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 430, 185, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 431, 152, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 515, 278, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 438, 129, 0, 1005));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 444, 125, 0, 1005));
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

