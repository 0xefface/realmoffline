using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5612 : Room
  {
        public Room5612()
            : base(5612, "Vlador's Tavern")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.Down;
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 384, 29, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 158, 38, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2508, 503, 46, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 211, 61, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 243, 51, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 654, 64, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2613, 275, 84, 3, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 217, 152, 82, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(35381, 605, 86, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 148, 68, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2621, 741, 82, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 241, 82, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2647, 290, 204, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2643, 289, 222, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 281, 156, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 281, 222, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 594, 229, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 109, 136, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 109, 194, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2643, 402, 202, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2643, 606, 232, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2647, 402, 100, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2642, 402, 154, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 606, 174, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2667, 600, 217, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 414, 203, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2662, 414, 144, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2662, 414, 77, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 292, 221, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2649, 290, 92, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2650, 337, 212, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 618, 229, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 307, 238, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 684, 270, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2650, 336, 85, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 112, 200, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 114, 208, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 218, 220, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 426, 214, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 528, 101, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 426, 83, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 465, 97, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 542, 233, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 317, 178, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 200, 179, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 133, 169, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 480, 236, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2734, 468, 200, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 263, 231, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 328, 180, 14, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 213, 187, 20, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 148, 177, 20, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 279, 236, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 605, 237, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 290, 227, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(32814, 112, 200, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 71, 319, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 155, 215, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 288, 233, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 50, 324, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 596, 242, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2731, 382, 135, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 63, 171, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 113, 180, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 71, 270, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2728, 504, 120, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(35468, 400, 64, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2732, 288, 216, 0, 5612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2733, 112, 178, 0, 5612));
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

