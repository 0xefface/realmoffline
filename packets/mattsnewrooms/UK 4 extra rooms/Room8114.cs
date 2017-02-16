using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8114 : Room
  {
        public Room8114()
            : base(8114, "Excellent Weaponry Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 183, 2, 0, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 389, 16, 0, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(34989, 49, 172, 0, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 81, 8, 0, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 477, 25, 0, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 474, 77, 0, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 429, 183, 0, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 619, 97, 65516, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2120, 428, 183, 0, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 141, 289, 0, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 182, 96, 65526, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 385, 84, 65516, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(34888, 142, 291, 60, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2106, 181, 185, 0, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 582, 111, 0, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 161, 103, 0, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 287, 7, 0, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 591, 41, 20, 8114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 364, 101, 0, 8114));
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

