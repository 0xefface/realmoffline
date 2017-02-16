using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4025 : Room
  {
        public Room4025()
            : base(4025, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 110, 0, 4025));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 4025));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 104, 0, 4025));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 440, 335, 0, 4025));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 184, 235, 0, 4025));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 170, 249, 0, 4025));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 27, 133, 0, 4025));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 136, 244, 0, 4025));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 188, 234, 0, 4025));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 169, 221, 0, 4025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 17, 132, 0, 4025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 41, 132, 0, 4025));
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

