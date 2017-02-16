using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4006 : Room
  {
        public Room4006()
            : base(4006, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 420, 236, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 97, 314, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 93, 321, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 407, 238, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 27, 115, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 84, 121, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 598, 124, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 52, 120, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 120, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 104, 120, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 576, 124, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 600, 124, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 624, 124, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2921, 578, 70, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 167, 107, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 533, 106, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(198, 577, 53, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(198, 103, 57, 0, 4006));
          this.AddRoomDecoration(RoomDecoration.FromCode(194, 333, 104, 0, 4006));
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

