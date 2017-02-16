using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4016 : Room
  {
        public Room4016()
            : base(4016, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 106, 116, 0, 4016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 4016));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 102, 0, 4016));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 170, 188, 0, 4016));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 413, 282, 0, 4016));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 172, 192, 0, 4016));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 381, 109, 0, 4016));
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

