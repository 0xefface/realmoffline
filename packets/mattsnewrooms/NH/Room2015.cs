using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2015 : Room
  {
        public Room2015()
            : base(2015, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 515, 108, 0, 2015));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 178, 108, 0, 2015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 574, 309, 0, 2015));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 564, 318, 0, 2015));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 338, 168, 0, 2015));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 305, 104, 0, 2015));
          this.AddRoomDecoration(RoomDecoration.FromCode(240, 328, 1, 0, 2015));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 255, 106, 0, 2015));
          this.AddRoomDecoration(RoomDecoration.FromCode(32920, 37, 121, 0, 2015));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 84, 110, 0, 2015));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 19, 138, 0, 2015));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 2, 327, 0, 2015));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 29, 222, 0, 2015));
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

