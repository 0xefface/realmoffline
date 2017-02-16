using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5301 : Room
  {
        public Room5301()
            : base(5301, "Mixers and Makers")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2508, 123, 77, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 274, 95, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 337, 96, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 424, 82, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 470, 62, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 239, 124, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 431, 181, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 403, 86, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 44, 190, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 45, 78, 10, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 307, 206, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 368, 193, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 349, 106, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 319, 209, 15, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 379, 196, 15, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 442, 187, 15, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 61, 197, 21, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 62, 82, 29, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 11, 229, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 656, 171, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 637, 165, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 327, 255, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2733, 228, 262, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 618, 131, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 13, 247, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 291, 258, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 0, 188, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(35562, 299, 172, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2802, 261, 180, 22, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 435, 253, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 100, 296, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 343, 268, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 414, 259, 0, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 37, 76, 65397, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 310, 290, 65397, 5301));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 15, 231, 0, 5301));
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

