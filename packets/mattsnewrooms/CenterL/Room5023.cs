using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5023 : Room
  {
        public Room5023()
            : base(5023, "Meditation Garden")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 76, 33, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 556, 35, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 648, 249, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 65515, 251, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 403, 191, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 431, 189, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 423, 167, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 198, 191, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 222, 104, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 235, 159, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 203, 164, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 252, 192, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 409, 163, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 296, 113, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 210, 131, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 451, 138, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 330, 95, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 435, 118, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 399, 142, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 232, 141, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 401, 220, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 473, 184, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 149, 183, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 225, 222, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 318, 180, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 292, 178, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 345, 176, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 310, 154, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 356, 161, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 286, 159, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 269, 168, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 361, 172, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 336, 159, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 459, 227, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 147, 189, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 305, 112, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 471, 192, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 318, 240, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 158, 228, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 278, 119, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 337, 120, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 599, 59, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 46, 60, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 227, 135, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 399, 137, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 144, 178, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 479, 184, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 93, 281, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 30, 264, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 536, 284, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 620, 269, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 46, 64, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 41, 306, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 602, 310, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 38, 312, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 601, 313, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 612, 60, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 277, 175, 0, 5023));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 15, 361, 0, 5023));
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

