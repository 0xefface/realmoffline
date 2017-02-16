using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5905 : Room
  {
        public Room5905()
            : base(5905, "Thor's Thunder")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 359, 52, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 272, 53, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 207, 28, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 456, 53, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 490, 59, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2649, 439, 60, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 204, 144, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 345, 189, 20, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 345, 213, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 447, 126, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 508, 121, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 221, 66, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2656, 406, 188, 65508, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2651, 396, 91, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 500, 194, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2654, 501, 100, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 148, 72, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(34364, 500, 218, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2601, 408, 404, 306, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 258, 209, 116, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 202, 198, 116, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2601, 303, 260, 179, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 263, 145, 45, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 215, 349, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 632, 172, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 144, 189, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 159, 188, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2601, 632, 180, 142, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 510, 20, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 301, 176, 20, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 248, 153, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 301, 206, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 487, 94, 49, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 265, 94, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2654, 438, 60, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 160, 197, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 211, 213, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 342, 229, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 271, 223, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 342, 108, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 246, 182, 31, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 247, 203, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2671, 160, 122, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 280, 156, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2673, 349, 213, 65532, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2674, 348, 152, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2676, 161, 163, 65526, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 220, 153, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 205, 182, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 205, 175, 31, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(1538, 557, 209, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(1586, 591, 200, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(1596, 508, 206, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(1596, 481, 211, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(34289, 397, 233, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(1522, 332, 222, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(34288, 338, 232, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(1520, 190, 20, 65387, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(1587, 43, 151, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(1587, 530, 211, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(34355, 563, 201, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(1588, 82, 186, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(1585, 118, 265, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(34353, 0, 94, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(34353, 26, 113, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(1586, 391, 207, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 632, 173, 5, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 350, 235, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 660, 232, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(1587, 73, 88, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(1537, 7, 126, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(1587, 336, 208, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 598, 42, 0, 5905));
          this.AddRoomDecoration(RoomDecoration.FromCode(2601, 657, 197, 142, 5905));
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

