using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6210 : Room
  {
        public Room6210()
            : base(6210, "Mabon's Secrets Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 447, 6, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 480, 24, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 42, 33, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 129, 7, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 231, 1, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 287, 11, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 344, 1, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 543, 20, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 542, 34, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 607, 72, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 542, 48, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2106, 86, 281, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 601, 194, 20, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 288, 162, 50, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 252, 129, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 549, 186, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 98, 168, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2147, 87, 284, 60, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2148, 48, 170, 65526, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2149, 47, 172, 20, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2600, 379, 277, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2116, 268, 92, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2116, 233, 92, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2116, 132, 92, 0, 6210));
          this.AddRoomDecoration(RoomDecoration.FromCode(2116, 96, 92, 0, 6210));
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

