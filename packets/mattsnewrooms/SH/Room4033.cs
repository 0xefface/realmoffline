using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4033 : Room
  {
        public Room4033()
            : base(4033, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 619, 327, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 531, 275, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 602, 329, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 257, 103, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 36, 102, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 513, 106, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 89, 114, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 127, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 252, 102, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 385, 196, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 469, 202, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 192, 126, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 377, 120, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 299, 117, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 26, 134, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 441, 126, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 513, 129, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 597, 127, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 344, 226, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 324, 197, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 465, 222, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 410, 198, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 576, 220, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 535, 201, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 257, 122, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 237, 159, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 568, 200, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 335, 206, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 286, 193, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 576, 126, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 600, 126, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 20, 134, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 43, 134, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 161, 126, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 126, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 205, 127, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 127, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 275, 118, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 298, 118, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 322, 118, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 354, 120, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 377, 119, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 119, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 433, 124, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 456, 124, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 491, 129, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 515, 129, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 129, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 166, 206, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 166, 195, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 69, 206, 0, 4033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 72, 195, 0, 4033));
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

