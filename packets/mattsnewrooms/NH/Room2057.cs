using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2057 : Room
  {
        public Room2057()
            : base(2057, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Down;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 298, 103, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 114, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 184, 124, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 476, 248, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 414, 266, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 84, 225, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 68, 223, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 463, 250, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 368, 270, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(241, 420, 52, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 536, 108, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 506, 259, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 448, 278, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 101, 227, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 51, 104, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 15, 103, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 71, 238, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 112, 217, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 478, 233, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 512, 240, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 119, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 303, 125, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 280, 126, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 256, 124, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 232, 124, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 208, 124, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 184, 124, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 160, 124, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 137, 125, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 114, 125, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 90, 124, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 64, 122, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 386, 117, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 431, 120, 0, 2057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 449, 121, 0, 2057));
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

