using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7016 : Room
  {
        public Room7016()
            : base(7016, "Kurz Trading Post")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2508, 123, 74, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 274, 95, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 305, 99, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 354, 92, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 407, 73, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 11, 229, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 637, 345, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 444, 248, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 7, 239, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 474, 139, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 592, 148, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 13, 247, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 245, 273, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 443, 256, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 537, 303, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(32814, 623, 107, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 610, 166, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 382, 256, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 37, 76, 65397, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 310, 290, 65397, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 0, 188, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 448, 250, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(35381, 229, 108, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 246, 233, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 327, 220, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 95, 200, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 96, 78, 13, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 263, 206, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 344, 193, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 95, 194, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 96, 78, 19, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(35381, 337, 108, 16, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 404, 95, 65342, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 253, 264, 0, 7016));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 561, 284, 0, 7016));
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

