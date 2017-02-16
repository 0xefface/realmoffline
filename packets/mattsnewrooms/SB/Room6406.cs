using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6406 : Room
  {
        public Room6406()
            : base(6406, "Shop of Defense Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 181, 8, 0, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 387, 22, 0, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(34989, 76, 170, 0, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 159, 236, 0, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 492, 30, 0, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 441, 190, 0, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2119, 447, 191, 33, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(34888, 388, 284, 58, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2119, 447, 191, 4, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2139, 94, 237, 44, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 322, 62, 0, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 345, 337, 65446, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 391, 283, 0, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 593, 45, 20, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 285, 13, 0, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 144, 98, 65516, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 566, 116, 65516, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 180, 103, 0, 6406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 619, 125, 0, 6406));
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

