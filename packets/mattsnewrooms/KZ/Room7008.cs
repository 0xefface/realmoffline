using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7008 : Room
  {
        public Room7008()
            : base(7008, "Kurz Mercantile")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 24, 296, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 283, 14, 65437, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 33, 4, 65437, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 295, 197, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 391, 42, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 454, 42, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 422, 48, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 399, 59, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 450, 64, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 176, 96, 20, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 18, 188, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 53, 219, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 292, 49, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 185, 56, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 94, 55, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 134, 60, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 249, 93, 30, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 107, 75, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 182, 146, 65516, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 107, 145, 65516, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 457, 133, 65516, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 386, 133, 65516, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 363, 209, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2244, 398, 213, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 467, 204, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 517, 194, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 442, 214, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 67, 218, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 207, 210, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 637, 313, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 240, 217, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 10, 210, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 498, 222, 16, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 15, 199, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 527, 188, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 439, 202, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 420, 206, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 401, 207, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 382, 207, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 362, 205, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 346, 202, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 181, 163, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 107, 160, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 387, 147, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 457, 150, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 108, 181, 0, 7008));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 370, 181, 0, 7008));
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

