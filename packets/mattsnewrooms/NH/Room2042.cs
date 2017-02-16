using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2042 : Room
  {
        public Room2042()
            : base(2042, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 505, 110, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 184, 124, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 532, 226, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 512, 215, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 508, 230, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 531, 216, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 54, 155, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 337, 103, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 65526, 103, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 134, 103, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 338, 103, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 510, 103, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(33009, 426, 25, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 311, 153, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 328, 146, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 147, 171, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 133, 170, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 124, 169, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 323, 156, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(244, 365, 47, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 225, 170, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 126, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 86, 126, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 126, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 133, 124, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 155, 124, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 124, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 202, 125, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 226, 125, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 125, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 125, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 297, 124, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 306, 124, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 644, 299, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 615, 311, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 45, 162, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 109, 176, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 194, 177, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 303, 162, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 331, 123, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 309, 161, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 322, 151, 0, 2042));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 316, 156, 0, 2042));
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

