using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5403 : Room
  {
        public Room5403()
            : base(5403, "Litula's Sundries")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 33, 31, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 81, 53, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 167, 52, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 309, 32, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 79, 56, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 111, 62, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2628, 198, 74, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 232, 189, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 74, 166, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 249, 162, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 74, 160, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 434, 192, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 79, 261, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 519, 264, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 469, 184, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 242, 279, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 551, 129, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 660, 153, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 622, 91, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 640, 46, 65485, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 4, 222, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 507, 8, 65456, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 385, 17, 65437, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 244, 225, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2958, 134, 207, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2958, 401, 320, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(35726, 316, 218, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(35726, 251, 230, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 474, 185, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 592, 8, 65437, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 318, 177, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 335, 150, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2652, 320, 52, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 348, 59, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 387, 201, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 598, 109, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 212, 90, 21, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 87, 76, 21, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 326, 213, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 289, 221, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2244, 234, 224, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 435, 188, 100, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 509, 205, 100, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 548, 77, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(32782, 218, 247, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(32782, 341, 227, 0, 5403));
          this.AddRoomDecoration(RoomDecoration.FromCode(14, 124, 233, 0, 5403));
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

