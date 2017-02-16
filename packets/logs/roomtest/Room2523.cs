using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2523 : Room
  {
        public Room2523()
            : base(2523, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 93, 128, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(35511, 573, 134, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 440, 139, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 632, 140, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 169, 135, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 575, 137, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 210, 142, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 361, 141, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 275, 144, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 59, 129, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 448, 218, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 516, 222, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 513, 221, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 121, 129, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 354, 201, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 593, 258, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 71, 131, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 324, 202, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 22, 208, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 214, 238, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 309, 198, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 424, 322, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 599, 257, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 264, 185, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 321, 181, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 380, 179, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 490, 182, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 566, 178, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 614, 176, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 260, 353, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 8, 220, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 7, 223, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 54, 129, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 129, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 145, 135, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 169, 135, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 192, 135, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 259, 144, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 283, 144, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 138, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 141, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 360, 192, 0, 2523));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 377, 191, 0, 2523));
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

