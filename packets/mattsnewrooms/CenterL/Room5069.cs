using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5069 : Room
  {
        public Room5069()
            : base(5069, "Leinster")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 306, 213, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 24, 138, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 250, 195, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 61, 139, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 540, 138, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 180, 278, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 58, 580, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 60, 138, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 101, 138, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 136, 138, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 170, 139, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 172, 124, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 174, 105, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 176, 87, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 180, 73, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 183, 57, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 622, 138, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 584, 138, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 544, 137, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 503, 137, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 464, 137, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 431, 135, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 427, 121, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 424, 106, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 422, 90, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 419, 77, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 417, 60, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 246, 224, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 364, 200, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 256, 183, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 365, 213, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 357, 185, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 363, 223, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 308, 203, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 308, 219, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 306, 223, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 303, 183, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 248, 210, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 25, 275, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 64, 275, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 107, 276, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 146, 277, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 541, 580, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 177, 293, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 174, 311, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 172, 330, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 626, 275, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 585, 275, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 542, 274, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 502, 275, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 460, 275, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 424, 275, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 427, 286, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 431, 304, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 437, 321, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 89, 267, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 634, 273, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 492, 271, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 125, 278, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 96, 14, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 44, 56, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 82, 41, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 526, 10, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 603, 47, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 527, 56, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 636, 11, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 71, 83, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 547, 82, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 73, 320, 0, 5069));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 560, 317, 0, 5069));
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

