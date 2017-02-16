using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2022 : Room
  {
        public Room2022()
            : base(2022, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 419, 104, 0, 2022));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 94, 105, 0, 2022));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 65496, 104, 0, 2022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 100, 116, 0, 2022));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 586, 113, 0, 2022));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 94, 273, 0, 2022));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 113, 274, 0, 2022));
          this.AddRoomDecoration(RoomDecoration.FromCode(33012, 65512, 7, 0, 2022));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 224, 104, 0, 2022));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 267, 105, 0, 2022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 443, 111, 0, 2022));
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

