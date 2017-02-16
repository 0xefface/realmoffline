using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2026 : Room
  {
        public Room2026()
            : base(2026, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 94, 186, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 553, 239, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 531, 275, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 72, 202, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 245, 104, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 36, 102, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 479, 118, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(244, 204, 47, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 537, 240, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 134, 184, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 65531, 184, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 119, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 404, 120, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 120, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 120, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 120, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 498, 119, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 522, 119, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 542, 120, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 119, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 117, 0, 2026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 615, 114, 0, 2026));
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

