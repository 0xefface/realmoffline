using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4044 : Room
  {
        public Room4044()
            : base(4044, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 266, 105, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 102, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 263, 104, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 265, 104, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 430, 115, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 653, 126, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 89, 124, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 53, 190, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 406, 226, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 365, 182, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 429, 211, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(102, 65519, 319, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 167, 135, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 537, 140, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 413, 136, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 118, 192, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 279, 192, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(32994, 625, 183, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 61, 211, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 353, 184, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 92, 124, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 74, 192, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 198, 193, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 509, 192, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 415, 227, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 193, 208, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 335, 210, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 477, 136, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 131, 135, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 158, 138, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 594, 151, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 639, 320, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 618, 224, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 428, 193, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 563, 153, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 562, 149, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 588, 153, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 607, 154, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 588, 148, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 98, 133, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 115, 133, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 132, 134, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 148, 134, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 165, 134, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 182, 134, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 444, 134, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 461, 134, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 478, 134, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 496, 134, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 513, 134, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 531, 134, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 549, 134, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 557, 134, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 589, 192, 0, 4044));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 618, 209, 0, 4044));
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

