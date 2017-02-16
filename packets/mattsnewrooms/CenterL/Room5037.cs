using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5037 : Room
  {
        public Room5037()
            : base(5037, "Smiting Memorial")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 575, 73, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(2749, 495, 97, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(35517, 140, 93, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 572, 416, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(35514, 429, 74, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 72, 278, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 62, 43, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 557, 42, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 552, 339, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 310, 51, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(1588, 340, 188, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(34356, 300, 186, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(34355, 335, 182, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(1587, 305, 181, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 90, 339, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 13, 113, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 45, 91, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 604, 107, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32899, 31, 104, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(132, 21, 126, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 585, 93, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 613, 104, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 562, 275, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 569, 106, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 123, 417, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 397, 77, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 320, 75, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 642, 392, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 608, 108, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(2747, 202, 74, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 170, 288, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 446, 291, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 60, 80, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 240, 135, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 313, 77, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 392, 227, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 20, 252, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 625, 249, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 352, 295, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 44, 385, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 276, 292, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(35482, 567, 92, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 316, 46, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 251, 225, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 64, 91, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 226, 225, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 173, 175, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 392, 134, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 461, 180, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 415, 226, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 271, 136, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32899, 252, 82, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 369, 134, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 306, 85, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 211, 60, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 181, 258, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 586, 105, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 346, 59, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 455, 258, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 2, 109, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 313, 81, 0, 5037));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 419, 62, 0, 5037));
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

