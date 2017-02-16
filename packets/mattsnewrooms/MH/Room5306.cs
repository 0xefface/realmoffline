using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5306 : Room
  {
        public Room5306()
            : base(5306, "Bewitchment's Best")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 68, 45, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 152, 209, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 263, 82, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 93, 262, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 54, 213, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 5, 211, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 57, 197, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 28, 198, 65516, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 65528, 239, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 633, 166, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 11, 177, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 213, 240, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 293, 234, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 643, 185, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 55, 225, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 482, 208, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 3, 228, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 626, 170, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 392, 293, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 77, 4, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 138, 0, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(25, 328, 5, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 543, 259, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(25, 20, 88, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 83, 34, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 245, 322, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 117, 211, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 87, 270, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 694, 149, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 578, 130, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 639, 36, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 120, 212, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 65527, 97, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 65527, 143, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 47, 219, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(32793, 637, 95, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 638, 87, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 120, 54, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 200, 69, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 192, 77, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 343, 51, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2518, 407, 68, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2517, 448, 29, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 159, 77, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 506, 1, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 320, 188, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2609, 402, 50, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 186, 190, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 295, 170, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2596, 175, 171, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2735, 253, 128, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2698, 464, 121, 0, 5306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2708, 447, 76, 0, 5306));
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

