using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5410 : Room
  {
        public Room5410()
            : base(5410, "Silver Park")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Up;
          this.AddRoomDecoration(RoomDecoration.FromCode(172, 45, 109, 0, 5410));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 272, 110, 0, 5410));
          this.AddRoomDecoration(RoomDecoration.FromCode(171, 359, 104, 0, 5410));
          this.AddRoomDecoration(RoomDecoration.FromCode(33009, 262, 38, 0, 5410));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 536, 51, 0, 5410));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 115, 167, 0, 5410));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 313, 167, 0, 5410));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 500, 167, 0, 5410));
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

