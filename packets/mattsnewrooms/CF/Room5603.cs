using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5603 : Room
  {
        public Room5603()
            : base(5603, "Caer Fandry Chapel")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.Up;
          this.AddRoomDecoration(RoomDecoration.FromCode(32811, 416, 198, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 250, 191, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2748, 111, 13, 65399, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 118, 11, 65427, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 93, 177, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 5, 189, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 88, 183, 65, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 36, 25, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 379, 219, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 48, 192, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 293, 216, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 596, 221, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 95, 23, 65408, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 339, 208, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 632, 209, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 65516, 190, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 579, 196, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 554, 201, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(181, 470, 203, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(180, 65, 182, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 317, 38, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(123, 60, 177, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 71, 168, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(35382, 65525, 56, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 65530, 68, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 6, 185, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 449, 43, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2746, 65527, 8, 65396, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 545, 277, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 106, 279, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(186, 585, 278, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 577, 45, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2617, 330, 49, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2617, 459, 50, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2558, 338, 106, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2549, 339, 109, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2585, 337, 187, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2618, 338, 66, 15, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2527, 340, 60, 49, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 317, 185, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2527, 491, 61, 49, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2618, 491, 67, 15, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2617, 579, 50, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2527, 640, 60, 49, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2618, 639, 69, 15, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2549, 639, 111, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2558, 638, 108, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2585, 637, 189, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 617, 187, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 263, 195, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 564, 199, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 403, 199, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 425, 203, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 280, 197, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2702, 490, 79, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(2748, 310, 290, 65399, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 239, 11, 65406, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 188, 74, 0, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(164, 163, 8, 65476, 5603));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 177, 3, 65476, 5603));
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

