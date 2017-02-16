using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8309 : Room
  {
        public Room8309()
            : base(8309, "Weaponry of Drune Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 148, 112, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 389, 16, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(34989, 49, 172, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 81, 8, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 477, 25, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 474, 77, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 429, 183, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2119, 433, 184, 63, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2120, 428, 183, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 141, 291, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 279, 291, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2119, 142, 292, 5, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(34888, 283, 292, 60, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2121, 140, 292, 34, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2121, 289, 292, 4, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 597, 183, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 287, 7, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 591, 41, 20, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(34907, 652, 185, 65521, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(34905, 651, 185, 13, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 180, 4, 65526, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2106, 181, 185, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 566, 125, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 358, 116, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2048, 565, 142, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 353, 130, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 143, 126, 0, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 618, 128, 14, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2555, 183, 112, 14, 8309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2555, 393, 116, 14, 8309));
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

