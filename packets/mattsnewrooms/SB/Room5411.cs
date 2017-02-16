using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5411 : Room
  {
        public Room5411()
            : base(5411, "Silverbrook Chapel")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 358, 34, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 181, 46, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2508, 503, 46, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 196, 56, 65523, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 222, 51, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 654, 64, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2613, 261, 64, 3, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 237, 137, 82, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(35381, 605, 86, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 122, 57, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2621, 741, 82, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 52, 144, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2647, 262, 191, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2643, 264, 213, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 254, 55, 65445, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 253, 212, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 594, 229, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 131, 182, 49, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 131, 201, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2643, 402, 202, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2643, 606, 232, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2647, 402, 100, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2642, 402, 154, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 606, 174, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2667, 600, 217, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 414, 203, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2662, 414, 144, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2662, 414, 77, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 265, 225, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2649, 269, 86, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2650, 337, 212, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 618, 229, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 264, 87, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2649, 276, 222, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2650, 337, 75, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 130, 213, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 128, 219, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 199, 224, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 426, 214, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 528, 92, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 426, 75, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 467, 89, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 529, 175, 65481, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 335, 176, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 192, 188, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 139, 179, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 51, 146, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 279, 186, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 290, 189, 14, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 346, 179, 14, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 209, 194, 20, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 156, 185, 20, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 398, 295, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2953, 632, 240, 9, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 270, 231, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2735, 527, 169, 65491, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 158, 53, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 110, 215, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 266, 241, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 135, 221, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 596, 242, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 591, 229, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 87, 275, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 259, 283, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 57, 5, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 53, 22, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(25, 84, 73, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 151, 49, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(35499, 160, 121, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2732, 269, 217, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(35501, 401, 52, 0, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(35575, 436, 268, 150, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(2702, 408, 309, 200, 5411));
          this.AddRoomDecoration(RoomDecoration.FromCode(35478, 439, 209, 150, 5411));
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

