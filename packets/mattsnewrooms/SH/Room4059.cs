using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4059 : Room
  {
        public Room4059()
            : base(4059, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 102, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 103, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 424, 135, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 666, 131, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 11, 320, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 518, 219, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 546, 318, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 480, 220, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 633, 187, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 618, 191, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 601, 202, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 37, 265, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 467, 218, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 65, 129, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 365, 145, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 464, 144, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 340, 146, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 368, 146, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 386, 146, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 347, 141, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 369, 140, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 383, 140, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 435, 144, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 434, 139, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 129, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 61, 129, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 123, 121, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 146, 122, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 169, 121, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 133, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 325, 134, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 407, 135, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 131, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 593, 132, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 616, 131, 0, 4059));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 523, 226, 0, 4059));
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

