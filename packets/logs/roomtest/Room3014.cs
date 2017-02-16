using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3014 : Room
  {
        public Room3014()
            : base(3014, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 533, 145, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 145, 142, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 89, 150, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 39, 143, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 581, 140, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 476, 190, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 132, 232, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 48, 320, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 470, 191, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 283, 122, 15, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 65509, 207, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 77, 208, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 558, 121, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 75, 134, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 349, 133, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 429, 126, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 244, 121, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 286, 122, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 326, 127, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 260, 123, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 316, 119, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 142, 132, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 11, 136, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 504, 139, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 409, 133, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 38, 146, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 302, 205, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 117, 203, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 265, 354, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 210, 84, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 292, 245, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 300, 236, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 606, 254, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 364, 227, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 309, 243, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 229, 158, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 634, 320, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 248, 159, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 143, 155, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 280, 156, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 170, 135, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 222, 155, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 181, 242, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(1110, 109, 243, 19, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 376, 159, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 390, 148, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(33000, 441, 110, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 415, 145, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 430, 139, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 433, 134, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 163, 140, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 97, 149, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 73, 149, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 143, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 143, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 555, 143, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 578, 141, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 344, 133, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 368, 133, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 392, 133, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 415, 133, 0, 3014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 17, 141, 0, 3014));
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

