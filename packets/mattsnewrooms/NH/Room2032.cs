using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2032 : Room
  {
        public Room2032()
            : base(2032, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 512, 113, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 103, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 561, 176, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 557, 194, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 321, 197, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 329, 196, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 268, 355, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 39, 312, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 228, 288, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 129, 304, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 133, 286, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 178, 213, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 550, 198, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 140, 297, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 95, 292, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 325, 211, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 197, 305, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 228, 294, 0, 2032));
          this.AddRoomDecoration(RoomDecoration.FromCode(245, 296, 27, 0, 2032));
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

