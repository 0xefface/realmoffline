using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5605 : Room
  {
        public Room5605()
            : base(5605, "Pretty Nice Clothing")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 229, 22, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 417, 156, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(35381, 563, 127, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 383, 42, 50, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 196, 146, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 609, 120, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 280, 188, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2731, 606, 192, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 333, 1, 1, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2691, 383, 163, 65, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(35382, 624, 69, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2613, 267, 34, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 487, 202, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 221, 194, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 426, 194, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 589, 208, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 266, 109, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(35483, 189, 139, 65506, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 204, 147, 20, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 496, 149, 65506, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 561, 182, 20, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 630, 195, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 561, 200, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2621, 699, 121, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 128, 27, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 381, 179, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 175, 178, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 656, 240, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2708, 369, 141, 82, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2734, 564, 176, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 519, 227, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(2732, 565, 192, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 73, 273, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 27, 35, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 28, 238, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 18, 67, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 65528, 151, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(32793, 25, 101, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(27, 28, 211, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 19, 111, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(32793, 10, 186, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(44, 42, 311, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 7, 130, 0, 5605));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 42, 312, 0, 5605));
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

