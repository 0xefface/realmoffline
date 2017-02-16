using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2053 : Room
  {
        public Room2053()
            : base(2053, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Down;
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 515, 108, 0, 2053));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 40, 108, 0, 2053));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 587, 319, 0, 2053));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 112, 184, 0, 2053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 142, 206, 0, 2053));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 129, 205, 0, 2053));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 588, 320, 0, 2053));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 108, 185, 0, 2053));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 104, 0, 2053));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 639, 56, 0, 2053));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 164, 211, 0, 2053));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 436, 323, 0, 2053));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 134, 180, 0, 2053));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 50, 323, 0, 2053));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 578, 311, 0, 2053));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 475, 110, 0, 2053));
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

