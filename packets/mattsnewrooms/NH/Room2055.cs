using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2055 : Room
  {
        public Room2055()
            : base(2055, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Down;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 2055));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 2055));
          this.AddRoomDecoration(RoomDecoration.FromCode(32943, 403, 104, 0, 2055));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 466, 304, 0, 2055));
          this.AddRoomDecoration(RoomDecoration.FromCode(32818, 50, 241, 0, 2055));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 37, 234, 0, 2055));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 355, 310, 0, 2055));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 33, 243, 0, 2055));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 27, 248, 0, 2055));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 401, 314, 0, 2055));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 428, 318, 0, 2055));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 43, 237, 0, 2055));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 14, 239, 0, 2055));
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

