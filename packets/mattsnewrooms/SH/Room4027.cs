using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4027 : Room
  {
        public Room4027()
            : base(4027, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32943, 329, 102, 0, 4027));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 106, 117, 0, 4027));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 472, 115, 0, 4027));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 407, 228, 0, 4027));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 372, 252, 0, 4027));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 306, 228, 0, 4027));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 493, 264, 0, 4027));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 485, 265, 0, 4027));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 601, 114, 0, 4027));
          this.AddRoomDecoration(RoomDecoration.FromCode(51, 270, 224, 0, 4027));
          this.AddRoomDecoration(RoomDecoration.FromCode(180, 317, 224, 0, 4027));
          this.AddRoomDecoration(RoomDecoration.FromCode(32948, 369, 224, 0, 4027));
          this.AddRoomDecoration(RoomDecoration.FromCode(181, 333, 221, 0, 4027));
          this.AllowCasting = False;
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

