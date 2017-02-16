using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2023 : Room
  {
        public Room2023()
            : base(2023, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 515, 108, 0, 2023));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 40, 108, 0, 2023));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 587, 319, 0, 2023));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 155, 208, 0, 2023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 120, 185, 0, 2023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32881, 150, 213, 0, 2023));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 588, 320, 0, 2023));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 113, 186, 0, 2023));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 104, 0, 2023));
          this.AddRoomDecoration(RoomDecoration.FromCode(33010, 601, 87, 0, 2023));
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

