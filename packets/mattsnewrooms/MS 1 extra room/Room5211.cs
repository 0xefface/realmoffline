using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5211 : Room
  {
        public Room5211()
            : base(5211, "Corie's Coiffures")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 272, 71, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 372, 76, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 600, 69, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 476, 75, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 526, 74, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 390, 232, 65526, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 57, 79, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 325, 227, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 653, 312, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 11, 314, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2631, 293, 78, 65526, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 416, 89, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2634, 582, 89, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 476, 89, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 27, 271, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 212, 209, 65516, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 212, 176, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(35529, 642, 71, 65480, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 527, 206, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 332, 217, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(35527, 640, 176, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 345, 206, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 638, 215, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 604, 227, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 618, 220, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 233, 227, 65526, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 176, 234, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 15, 185, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(32828, 266, 229, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 201, 221, 65526, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 65535, 196, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 17, 221, 65526, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 27, 199, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 12, 78, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 19, 224, 65526, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 30, 174, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 216, 71, 65480, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(35530, 641, 209, 65516, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 261, 206, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2604, 278, 177, 100, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2604, 422, 178, 100, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2604, 569, 178, 100, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 277, 178, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 361, 178, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 543, 178, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 310, 231, 65526, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 268, 230, 65526, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 611, 234, 65526, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 563, 230, 65526, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 224, 237, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 277, 241, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 330, 241, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 400, 241, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 512, 237, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 561, 241, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 617, 244, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 394, 227, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 548, 227, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 36, 233, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 0, 234, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 62, 62, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 41, 101, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 276, 237, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 594, 244, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 377, 237, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 0, 234, 0, 5211));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 475, 230, 0, 5211));
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

