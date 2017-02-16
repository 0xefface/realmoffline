using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2030 : Room
  {
        public Room2030()
            : base(2030, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 523, 111, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 151, 112, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 49, 175, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 11, 328, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 63, 171, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 304, 105, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 467, 325, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 598, 239, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 601, 240, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 429, 325, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 561, 325, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 31, 169, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 10, 327, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 246, 107, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 491, 111, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(243, 340, 28, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(32895, 6, 260, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 47, 135, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 37, 170, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 82, 135, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 66, 136, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 90, 136, 0, 2030));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 112, 136, 0, 2030));
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

