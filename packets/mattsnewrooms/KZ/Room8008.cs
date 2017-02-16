using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8008 : Room
  {
        public Room8008()
            : base(8008, "Kurz Mercantile Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 40, 1, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 143, 1, 8, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 249, 2, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 338, 3, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 461, 3, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 585, 3, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 188, 256, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 328, 255, 65535, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 544, 208, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 621, 323, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 582, 333, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 583, 312, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 634, 203, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 288, 152, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 191, 152, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 115, 160, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2116, 507, 87, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 289, 76, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 191, 77, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 534, 61, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 493, 76, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 117, 72, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 575, 76, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2160, 191, 256, 2, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2160, 252, 78, 20, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2244, 154, 166, 0, 8008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 382, 115, 0, 8008));
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

