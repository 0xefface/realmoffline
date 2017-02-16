using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7015 : Room
  {
        public Room7015()
            : base(7015, "The Gape")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2606, 161, 91, 150, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 518, 55, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2807, 483, 138, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 573, 211, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(35530, 470, 115, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(35528, 472, 220, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2953, 632, 194, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 145, 45, 65501, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 528, 229, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(35527, 472, 168, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 230, 223, 107, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 630, 218, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 636, 193, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2953, 533, 40, 65445, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 376, 166, 1, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 85, 4, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 145, 217, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 482, 71, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 203, 238, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 413, 62, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 375, 67, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 155, 225, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 156, 27, 65493, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 282, 60, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 360, 194, 1, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 551, 219, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 471, 168, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 228, 200, 35, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 491, 204, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 659, 0, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 471, 219, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 558, 60, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2758, 469, 114, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 229, 219, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 195, 235, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 182, 50, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2751, 202, 218, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2752, 206, 164, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2754, 207, 118, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 407, 222, 138, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(35379, 278, 224, 138, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 240, 82, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2799, 497, 139, 40, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2752, 132, 81, 65368, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2752, 131, 80, 65499, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2751, 129, 171, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 617, 215, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 415, 226, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 381, 222, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 41, 357, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 15, 295, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 110, 320, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 0, 114, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 65530, 74, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 32, 43, 0, 7015));
          this.AddRoomDecoration(RoomDecoration.FromCode(104, 15, 109, 0, 7015));
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

