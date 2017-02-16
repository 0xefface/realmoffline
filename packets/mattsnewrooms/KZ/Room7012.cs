using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7012 : Room
  {
        public Room7012()
            : base(7012, "Magic Mysteries")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 418, 7, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 246, 147, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 192, 104, 65506, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2698, 445, 152, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 7, 202, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 530, 162, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 574, 152, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 345, 18, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 34, 299, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 603, 12, 65486, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 632, 205, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 65509, 28, 65486, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2541, 274, 184, 65516, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2544, 288, 189, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2522, 594, 159, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 586, 217, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 583, 36, 65486, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 617, 222, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 61, 278, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 85, 92, 65486, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 29, 233, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 93, 104, 65466, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 106, 30, 65456, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 69, 18, 65516, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 163, 28, 65486, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 23, 76, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 51, 59, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 639, 91, 65436, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 121, 205, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 23, 206, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 27, 139, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 6, 332, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 27, 307, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 622, 227, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 524, 234, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 300, 213, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 332, 209, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 493, 227, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 461, 223, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 566, 230, 0, 7012));
          this.AddRoomDecoration(RoomDecoration.FromCode(94, 361, 4, 65486, 7012));
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

