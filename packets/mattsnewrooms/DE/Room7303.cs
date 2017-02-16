using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7303 : Room
  {
        public Room7303()
            : base(7303, "Exchange Emporium")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 525, 4, 65437, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 602, 1, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 605, 93, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 589, 2, 65437, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 332, 38, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 430, 42, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 380, 45, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 339, 59, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 432, 67, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 137, 96, 20, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 496, 142, 65476, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 11, 212, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 246, 42, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 142, 49, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 34, 48, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 96, 53, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 204, 93, 30, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 12, 78, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 129, 167, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 29, 163, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 432, 160, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 345, 160, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 363, 209, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2244, 398, 213, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 461, 200, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 500, 201, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 428, 199, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 22, 210, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 168, 214, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 60, 233, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 198, 204, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 325, 196, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 543, 120, 16, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 81, 209, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 520, 191, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 439, 202, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 420, 206, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 401, 207, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 382, 207, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 362, 205, 0, 7303));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 346, 202, 0, 7303));
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

