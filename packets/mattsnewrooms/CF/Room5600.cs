using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5600 : Room
  {
        public Room5600()
            : base(5600, "Necromancer's Wares")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 367, 44, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 382, 62, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 402, 50, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 280, 20, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 176, 42, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 502, 29, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 147, 52, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 130, 35, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 319, 204, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 456, 185, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 236, 184, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2556, 253, 157, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2556, 473, 158, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 303, 207, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2627, 75, 53, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 200, 55, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 211, 206, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2627, 325, 64, 18, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 447, 76, 28, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 450, 74, 8, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 328, 82, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 523, 209, 99, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2953, 21, 202, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 38, 191, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 27, 213, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 101, 212, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 305, 199, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 257, 204, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 171, 205, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 562, 4, 65474, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 310, 290, 65448, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 565, 56, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 608, 60, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 620, 62, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 624, 27, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 540, 203, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 524, 208, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 541, 215, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 506, 215, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 142, 194, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2806, 136, 121, 10, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2794, 124, 119, 0, 5600));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 228, 234, 0, 5600));
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

