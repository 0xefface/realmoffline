using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7308 : Room
  {
        public Room7308()
            : base(7308, "Drune Gatekeeper")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2606, 161, 91, 150, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 629, 71, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 516, 68, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 78, 232, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 131, 224, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2748, 504, 20, 65437, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 7, 228, 65534, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 42, 240, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 562, 131, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 583, 103, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 554, 100, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 469, 18, 65479, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 164, 224, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 131, 352, 231, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 36, 62, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(35529, 339, 113, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2605, 41, 226, 160, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 144, 216, 149, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2605, 288, 267, 200, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 281, 60, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 237, 167, 102, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2605, 217, 228, 160, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2605, 164, 227, 160, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 152, 60, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 212, 168, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 24, 229, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 324, 13, 65456, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 106, 218, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 192, 219, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 560, 12, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 613, 10, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(35528, 340, 165, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(35527, 341, 219, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 82, 216, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 447, 9, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 111, 288, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 434, 4, 65509, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 310, 290, 65509, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 65522, 239, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(2724, 248, 218, 0, 7308));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 258, 236, 0, 7308));
          this.AllowCasting = False;
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

