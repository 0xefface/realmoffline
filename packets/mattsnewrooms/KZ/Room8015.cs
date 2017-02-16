using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8015 : Room
  {
        public Room8015()
            : base(8015, "The Gape Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 470, 6, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 509, 26, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 135, 7, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 62, 31, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 238, 1, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 286, 11, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 18, 38, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 366, 1, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 545, 18, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 641, 20, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2394, 62, 42, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2395, 295, 18, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2393, 491, 34, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2392, 647, 43, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2391, 548, 43, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2390, 368, 18, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2392, 140, 81, 50, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2391, 473, 31, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2390, 240, 18, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2394, 26, 47, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2392, 648, 135, 65486, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2391, 550, 185, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2391, 473, 173, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2393, 492, 176, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2390, 369, 159, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2390, 240, 159, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2395, 298, 159, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2392, 141, 123, 65486, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2394, 59, 185, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2394, 25, 190, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 32, 194, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 343, 167, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 514, 185, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 502, 295, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 92, 293, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 296, 293, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2136, 65525, 199, 65526, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 564, 192, 65526, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 346, 176, 10, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2136, 65523, 199, 20, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2136, 65466, 237, 50, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 565, 193, 20, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 344, 176, 40, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 296, 329, 100, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 556, 304, 50, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2136, 31, 300, 50, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 130, 68, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 524, 127, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2080, 9, 137, 0, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 11, 181, 50, 8015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 488, 170, 50, 8015));
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

