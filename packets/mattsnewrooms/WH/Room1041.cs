using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1041 : Room
  {
        public Room1041()
            : base(1041, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Right;
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 443, 175, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32881, 428, 172, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 456, 168, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32958, 580, 127, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32964, 580, 107, 65516, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(33008, 76, 55, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 223, 226, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(33000, 238, 113, 20, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 102, 105, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32941, 647, 104, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 247, 103, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 429, 112, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 93, 105, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 548, 114, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(198, 694, 51, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32963, 622, 40, 65516, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 224, 215, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 241, 166, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 230, 125, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 232, 118, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 636, 307, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 599, 159, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 636, 286, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 636, 267, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 636, 247, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 636, 229, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 636, 208, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 627, 188, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 611, 167, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 595, 146, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 616, 181, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 588, 138, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 574, 121, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 556, 104, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 552, 89, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 579, 133, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 561, 116, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 310, 111, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 332, 112, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 354, 112, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 377, 113, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 398, 111, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 418, 111, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 442, 111, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 470, 111, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 493, 112, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 511, 112, 0, 1041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 534, 112, 0, 1041));
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

