using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4010 : Room
  {
        public Room4010()
            : base(4010, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Up;
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 222, 195, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 444, 322, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 222, 196, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 121, 107, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 373, 107, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 525, 106, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 1, 111, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 536, 122, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 100, 121, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 570, 114, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(32962, 523, 88, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(32963, 113, 50, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 492, 130, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(198, 62, 51, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 121, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 86, 121, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 107, 120, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 131, 120, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 466, 129, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 491, 130, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 516, 130, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 528, 121, 0, 4010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 553, 121, 0, 4010));
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

