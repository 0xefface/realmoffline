using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2520 : Room
  {
        public Room2520()
            : base(2520, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 93, 128, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(35511, 573, 134, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 197, 135, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 594, 138, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 150, 129, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 496, 134, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 210, 142, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 361, 141, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 257, 146, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 61, 132, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 554, 225, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 561, 229, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 501, 238, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 255, 145, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 286, 141, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 544, 239, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 18, 205, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 168, 199, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 21, 221, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 213, 217, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 145, 198, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 564, 310, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 538, 226, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 326, 144, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 207, 235, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 57, 135, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 490, 182, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 552, 178, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 599, 174, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 260, 353, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 150, 196, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 33, 222, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 104, 130, 20, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 198, 239, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 362, 287, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 446, 303, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 560, 311, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 483, 327, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 542, 217, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(32991, 214, 222, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 26, 219, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 182, 202, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 527, 229, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 493, 318, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(32991, 506, 251, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 560, 229, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(32991, 393, 191, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 104, 145, 20, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 107, 152, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 92, 189, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(32994, 288, 283, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 80, 131, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 57, 132, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 125, 129, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 174, 134, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 243, 145, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 267, 145, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 346, 140, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 368, 140, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 390, 140, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 453, 127, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 619, 139, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 309, 129, 0, 2520));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 287, 130, 0, 2520));
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

