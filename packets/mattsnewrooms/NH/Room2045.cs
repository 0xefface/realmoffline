using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2045 : Room
  {
        public Room2045()
            : base(2045, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Down;
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 514, 109, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 40, 108, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 257, 194, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 20, 165, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 2, 199, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 65520, 196, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 33, 168, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 306, 107, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(240, 300, 37, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 20, 225, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 54, 232, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 438, 189, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 266, 221, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 529, 170, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 54, 134, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 153, 231, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 362, 213, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 619, 169, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 544, 169, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 260, 195, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 0, 215, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 32, 204, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 26, 165, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 13, 160, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 37, 134, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 60, 134, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 134, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 599, 176, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 504, 171, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 431, 181, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 356, 204, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 273, 211, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 73, 234, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 145, 222, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 167, 214, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 147, 241, 0, 2045));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 169, 230, 0, 2045));
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

