using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4038 : Room
  {
        public Room4038()
            : base(4038, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 515, 108, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 40, 108, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 133, 185, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 615, 293, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 158, 203, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 153, 205, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 585, 296, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 121, 187, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 104, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 85, 207, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 400, 196, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 566, 195, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 27, 114, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 168, 113, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 417, 113, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 502, 213, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 38, 225, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 264, 224, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 357, 198, 0, 4038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 238, 204, 0, 4038));
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

