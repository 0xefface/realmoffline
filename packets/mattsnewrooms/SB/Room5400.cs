using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5400 : Room
  {
        public Room5400()
            : base(5400, "Silverbrook Charms")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 243, 10, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 418, 39, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 310, 39, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 560, 21, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 600, 137, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 426, 153, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 621, 202, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 536, 213, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 581, 214, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 402, 201, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 278, 179, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 461, 207, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 466, 64, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 373, 54, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 370, 192, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 192, 169, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 21, 194, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 497, 219, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 507, 153, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 426, 159, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 259, 130, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 490, 180, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2694, 485, 223, 100, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2710, 473, 183, 100, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 259, 136, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 287, 179, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 65500, 154, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 5, 93, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 338, 184, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 24, 269, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 279, 38, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 583, 164, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(32782, 468, 237, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(32782, 548, 223, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 635, 206, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 397, 196, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 22, 196, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 246, 185, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 436, 213, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 236, 181, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 82, 24, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 85, 55, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 39, 121, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 4, 187, 0, 5400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 376, 52, 0, 5400));
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

