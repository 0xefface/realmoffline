using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2012 : Room
  {
        public Room2012()
            : base(2012, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 395, 259, 0, 2012));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 431, 283, 0, 2012));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 389, 265, 0, 2012));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 408, 284, 0, 2012));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 407, 292, 0, 2012));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 467, 115, 0, 2012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 282, 123, 0, 2012));
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 63, 138, 0, 2012));
          this.AddRoomDecoration(RoomDecoration.FromCode(32944, 639, 102, 0, 2012));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 40, 138, 0, 2012));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 63, 138, 0, 2012));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 86, 138, 0, 2012));
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

