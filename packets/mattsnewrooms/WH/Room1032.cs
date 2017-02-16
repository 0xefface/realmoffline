using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1032 : Room
  {
        public Room1032()
            : base(1032, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 148, 106, 0, 1032));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 199, 230, 0, 1032));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 227, 233, 0, 1032));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 423, 320, 0, 1032));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 405, 20, 0, 1032));
          this.AddRoomDecoration(RoomDecoration.FromCode(32941, 625, 102, 0, 1032));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 541, 318, 0, 1032));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 28, 316, 0, 1032));
          this.AddRoomDecoration(RoomDecoration.FromCode(140, 194, 103, 0, 1032));
          this.AddRoomDecoration(RoomDecoration.FromCode(141, 231, 103, 0, 1032));
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

