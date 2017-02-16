using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6303 : Room
  {
        public Room6303()
            : base(6303, "House of Combat Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2120, 322, 260, 0, 6303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 463, 158, 0, 6303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 605, 184, 0, 6303));
          this.AddRoomDecoration(RoomDecoration.FromCode(34989, 59, 157, 0, 6303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 523, 8, 0, 6303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 166, 1, 0, 6303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 353, 1, 0, 6303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 613, 22, 0, 6303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 262, 11, 0, 6303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 264, 53, 0, 6303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 76, 53, 0, 6303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 103, 312, 0, 6303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2129, 112, 352, 100, 6303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2131, 39, 350, 100, 6303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2138, 358, 244, 0, 6303));
          this.AddRoomDecoration(RoomDecoration.FromCode(2105, 520, 287, 0, 6303));
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

