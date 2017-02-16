using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1029 : Room
  {
        public Room1029()
            : base(1029, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Right;
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 202, 210, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(32881, 187, 214, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 230, 213, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(32958, 582, 140, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(32964, 583, 138, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(240, 273, 17, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 403, 112, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(32941, 65396, 104, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 430, 114, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 65529, 106, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 231, 103, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 624, 224, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(197, 666, 94, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 638, 305, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 638, 284, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 638, 264, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 638, 243, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 638, 222, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 627, 201, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 612, 180, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 599, 162, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 585, 141, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 578, 122, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 589, 153, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 602, 174, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 617, 193, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 629, 211, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 579, 135, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 541, 115, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 520, 114, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 497, 116, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 312, 112, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 333, 113, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 356, 113, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 377, 114, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 401, 113, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 424, 113, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 449, 113, 0, 1029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 473, 113, 0, 1029));
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

