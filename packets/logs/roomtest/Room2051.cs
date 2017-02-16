using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2051 : Room
  {
        public Room2051()
            : base(2051, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Down;
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 451, 102, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 445, 103, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 54, 102, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 264, 102, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 424, 135, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 666, 131, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 471, 209, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 178, 265, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(244, 629, 42, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 174, 262, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 17, 324, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 485, 230, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 128, 257, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 25, 324, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 443, 219, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 436, 213, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 481, 213, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 302, 133, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 324, 135, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 348, 136, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 371, 135, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 395, 135, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 418, 135, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 441, 135, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 493, 137, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 516, 137, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 137, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 130, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 130, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 615, 130, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 130, 0, 2051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 118, 122, 0, 2051));
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

