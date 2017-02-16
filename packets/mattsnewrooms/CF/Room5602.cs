using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5602 : Room
  {
        public Room5602()
            : base(5602, "Emerald Forest Inn")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.Up;
          this.AddRoomDecoration(RoomDecoration.FromCode(2508, 123, 77, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 274, 95, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 337, 96, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 424, 82, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 508, 59, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 11, 229, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 555, 216, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 585, 195, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 588, 232, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 614, 181, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 635, 180, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 13, 247, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 245, 273, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 306, 277, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 527, 220, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(32814, 335, 247, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 610, 166, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 613, 217, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 37, 76, 65397, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 310, 290, 65397, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 0, 188, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 319, 254, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(35381, 229, 108, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 327, 226, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 408, 213, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 95, 200, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 96, 78, 13, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 344, 199, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 425, 186, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 95, 194, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 96, 78, 19, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(35381, 351, 104, 16, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(35381, 475, 68, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2708, 236, 164, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 564, 228, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 516, 1, 65342, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 442, 239, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(35559, 265, 207, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2798, 234, 215, 0, 5602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2735, 93, 124, 0, 5602));
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

