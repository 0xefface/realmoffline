using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2025 : Room
  {
        public Room2025()
            : base(2025, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 87, 110, 0, 2025));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 2025));
          this.AddRoomDecoration(RoomDecoration.FromCode(32943, 309, 103, 0, 2025));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 66, 254, 0, 2025));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 55, 247, 0, 2025));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 482, 179, 0, 2025));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 518, 185, 0, 2025));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 412, 167, 0, 2025));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 455, 248, 0, 2025));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 364, 202, 0, 2025));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 391, 198, 0, 2025));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 394, 205, 0, 2025));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 259, 106, 0, 2025));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 542, 105, 0, 2025));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 176, 103, 0, 2025));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 645, 214, 0, 2025));
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

