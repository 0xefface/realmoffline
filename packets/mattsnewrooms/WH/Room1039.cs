using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1039 : Room
  {
        public Room1039()
            : base(1039, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 85, 321, 0, 1039));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 455, 280, 0, 1039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 43, 226, 0, 1039));
          this.AddRoomDecoration(RoomDecoration.FromCode(125, 452, 268, 0, 1039));
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 594, 104, 0, 1039));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 65475, 106, 0, 1039));
          this.AddRoomDecoration(RoomDecoration.FromCode(244, 283, 85, 0, 1039));
          this.AddRoomDecoration(RoomDecoration.FromCode(33012, 254, 72, 0, 1039));
          this.AddRoomDecoration(RoomDecoration.FromCode(141, 345, 90, 0, 1039));
          this.AddRoomDecoration(RoomDecoration.FromCode(32910, 336, 97, 0, 1039));
          this.AddRoomDecoration(RoomDecoration.FromCode(145, 639, 107, 0, 1039));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 94, 105, 0, 1039));
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

