using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7314 : Room
  {
        public Room7314()
            : base(7314, "Daemon's Delight")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 314, 40, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 380, 61, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 416, 51, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 231, 20, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 131, 38, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 516, 31, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 95, 48, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 46, 25, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 329, 165, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 473, 186, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 190, 184, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2556, 207, 157, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2556, 490, 159, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2557, 330, 159, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 303, 207, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2627, 54, 50, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 517, 217, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 479, 222, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2627, 335, 73, 18, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 487, 222, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 401, 74, 8, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 478, 102, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 535, 202, 99, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2953, 0, 193, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 17, 202, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 69, 209, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 108, 212, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 448, 100, 34, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 322, 81, 34, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 93, 50, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 181, 63, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 171, 205, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 305, 199, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 257, 204, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 211, 206, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 348, 202, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2797, 95, 156, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(35478, 170, 88, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(35560, 133, 132, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 161, 222, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 214, 226, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 1, 167, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 181, 203, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 303, 199, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 323, 203, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 338, 201, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(1544, 530, 220, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(1542, 603, 320, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(34353, 514, 263, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(1586, 599, 212, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(1586, 636, 244, 0, 7314));
          this.AddRoomDecoration(RoomDecoration.FromCode(1587, 617, 1, 65352, 7314));
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

