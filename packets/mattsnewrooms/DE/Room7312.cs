using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7312 : Room
  {
        public Room7312()
            : base(7312, "Elven Enchantment")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2511, 275, 50, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2664, 236, 77, 65473, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2665, 321, 154, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2524, 412, 78, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2646, 332, 153, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 237, 148, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 268, 154, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2630, 337, 85, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(35371, 351, 89, 19, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2601, 455, 175, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2601, 234, 14, 65412, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 176, 148, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 405, 188, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2510, 217, 228, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2510, 304, 242, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 249, 156, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 633, 61, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2628, 332, 172, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 319, 171, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 481, 56, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 163, 234, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 528, 204, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 156, 213, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 455, 252, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 517, 252, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2698, 265, 108, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 45, 146, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 75, 179, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 49, 179, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(32952, 58, 168, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2749, 95, 6, 65456, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2531, 181, 2, 0, 7312));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 0, 2, 0, 7312));
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

