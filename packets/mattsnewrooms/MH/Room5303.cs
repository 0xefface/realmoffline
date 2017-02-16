using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5303 : Room
  {
        public Room5303()
            : base(5303, "House of Combat")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2508, 123, 77, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 274, 95, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 337, 96, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 424, 82, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 466, 66, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 239, 124, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 438, 184, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 407, 89, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 55, 211, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 45, 78, 10, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2733, 228, 251, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 378, 196, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 360, 103, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2735, 116, 133, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 390, 199, 15, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 449, 187, 15, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 68, 218, 21, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 62, 82, 29, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 11, 229, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 634, 209, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 192, 270, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 103, 262, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 138, 230, 21, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 124, 224, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 13, 247, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 197, 271, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 0, 188, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(35562, 285, 172, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2802, 247, 180, 22, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 288, 259, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(32814, 392, 234, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 158, 268, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 67, 266, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 37, 76, 65397, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 310, 290, 65397, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 15, 231, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 100, 296, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(35499, 117, 120, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 284, 261, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 404, 236, 0, 5303));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 635, 213, 0, 5303));
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

