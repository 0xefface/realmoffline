using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6300 : Room
  {
        public Room6300()
            : base(6300, "Monmouth Necessaries Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 40, 1, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 143, 1, 8, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 229, 3, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 338, 3, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 461, 3, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 585, 3, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 266, 244, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 533, 213, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 621, 323, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 582, 333, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 583, 312, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 629, 204, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 373, 152, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 277, 152, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 179, 152, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 115, 160, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2116, 507, 87, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 377, 81, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 280, 81, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 183, 81, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 534, 61, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 493, 76, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 117, 72, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 575, 76, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(34928, 267, 245, 2, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2160, 279, 82, 18, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2244, 143, 167, 0, 6300));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 272, 153, 20, 6300));
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

