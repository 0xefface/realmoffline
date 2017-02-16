using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5906 : Room
  {
        public Room5906()
            : base(5906, "Northlander Weaponry")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2511, 275, 50, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2664, 236, 77, 65473, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2665, 321, 154, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2524, 412, 78, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2646, 332, 153, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 237, 148, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 268, 154, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2630, 337, 85, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(35371, 351, 89, 19, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2601, 452, 183, 6, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2601, 234, 14, 65412, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 176, 148, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 405, 188, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2510, 210, 150, 65459, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2510, 304, 242, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 249, 156, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 633, 61, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2628, 343, 183, 12, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 319, 171, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 481, 56, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2807, 257, 128, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2801, 266, 131, 35, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2531, 154, 3, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2532, 231, 10, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 175, 11, 65523, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(34290, 154, 12, 65487, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(1536, 134, 221, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(34305, 191, 233, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(1586, 102, 200, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(1596, 580, 248, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(34364, 606, 246, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(34364, 662, 236, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(1588, 221, 221, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(34353, 26, 1, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(44, 140, 206, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(1588, 56, 289, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(1585, 102, 283, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(34353, 509, 276, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(1588, 507, 283, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(1535, 235, 241, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(34356, 429, 289, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 260, 265, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 405, 287, 0, 5906));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 399, 294, 0, 5906));
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

