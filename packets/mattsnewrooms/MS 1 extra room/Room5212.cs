using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5212 : Room
  {
        public Room5212()
            : base(5212, "Murias Chapel")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 37, 40, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 89, 45, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 323, 41, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 185, 44, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 253, 46, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 575, 81, 65526, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 600, 209, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 87, 196, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 653, 312, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 11, 317, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2631, 62, 54, 65526, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 185, 65, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2634, 316, 68, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 262, 65, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 27, 271, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 65531, 181, 65516, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 65530, 148, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(35529, 383, 50, 65480, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 278, 182, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 70, 193, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(35527, 384, 158, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 103, 185, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 8, 191, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 313, 195, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 618, 48, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 29, 196, 65526, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 65527, 210, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 390, 192, 65526, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(32828, 151, 194, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 576, 141, 65526, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 639, 181, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 617, 162, 65526, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 617, 84, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 598, 78, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 79, 203, 65526, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 597, 174, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 65533, 40, 65480, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(35530, 382, 181, 65516, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 23, 185, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2604, 47, 156, 100, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2604, 193, 160, 100, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2604, 296, 160, 100, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 39, 157, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 119, 157, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 294, 154, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 142, 199, 65526, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 618, 97, 65526, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 310, 196, 65526, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 352, 198, 65526, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 24, 209, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 77, 213, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 124, 209, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 256, 206, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 386, 206, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 554, 209, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 610, 209, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 15, 195, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 601, 196, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 295, 205, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 337, 206, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 355, 175, 65526, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 634, 129, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 633, 223, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 230, 195, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2702, 139, 160, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2702, 314, 160, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(2702, 58, 160, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 51, 223, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 321, 223, 0, 5212));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 401, 192, 0, 5212));
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

