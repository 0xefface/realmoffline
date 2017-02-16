using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6606 : Room
  {
        public Room6606()
            : base(6606, "Come and Get It Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2122, 316, 287, 4, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(34890, 333, 177, 32, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(34891, 323, 177, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2141, 46, 289, 47, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(34908, 579, 247, 40, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 524, 246, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 328, 176, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2111, 593, 117, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 315, 286, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 574, 15, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 607, 33, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 38, 40, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 199, 15, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 111, 42, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 301, 9, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 471, 9, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 414, 19, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(34910, 644, 118, 10, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 330, 177, 65, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 431, 178, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 579, 186, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2123, 324, 287, 30, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 17, 95, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 136, 76, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2162, 604, 75, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2041, 155, 138, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 431, 116, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 112, 288, 0, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2556, 165, 138, 14, 6606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2558, 465, 116, 14, 6606));
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

