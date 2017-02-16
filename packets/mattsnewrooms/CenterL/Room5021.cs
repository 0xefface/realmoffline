using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5021 : Room
  {
        public Room5021()
            : base(5021, "Redemption Square")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 76, 23, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 558, 20, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 648, 249, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 65515, 251, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 403, 191, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 431, 189, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 423, 167, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 198, 191, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 222, 104, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(1588, 351, 150, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 194, 153, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 252, 192, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 225, 180, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 292, 167, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 200, 136, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 419, 129, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 330, 95, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(34364, 329, 165, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 399, 142, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 232, 141, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 401, 220, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 473, 184, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 149, 183, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 225, 222, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 536, 284, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 620, 269, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 399, 137, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 41, 306, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 38, 312, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 93, 281, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 30, 264, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 601, 313, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 602, 310, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 459, 227, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 147, 189, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 305, 112, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 471, 192, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 318, 240, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 158, 228, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 278, 119, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 337, 120, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 144, 178, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 479, 184, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 227, 135, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 18, 69, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 74, 59, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 554, 55, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 610, 67, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(1596, 298, 164, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(1597, 308, 147, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(34366, 315, 146, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(1587, 310, 143, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(200, 67, 302, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 618, 303, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32904, 576, 299, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(132, 583, 57, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(134, 52, 61, 0, 5021));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 641, 352, 0, 5021));
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

