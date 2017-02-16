using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2020 : Room
  {
        public Room2020()
            : base(2020, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 277, 102, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 516, 123, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 177, 111, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 89, 146, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 421, 220, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 420, 237, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 96, 142, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 550, 326, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 395, 254, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 269, 277, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 65411, 105, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 430, 236, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 392, 122, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 416, 122, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 123, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 477, 123, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 501, 124, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 124, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 547, 123, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 123, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 594, 124, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 618, 125, 0, 2020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 630, 126, 0, 2020));
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

