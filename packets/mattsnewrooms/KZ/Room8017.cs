using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8017 : Room
  {
        public Room8017()
            : base(8017, "Elise's Provisions Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2122, 333, 189, 35, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2141, 65518, 212, 50, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(34910, 640, 183, 13, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(34908, 564, 246, 40, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 32, 211, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 503, 245, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 333, 188, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2111, 592, 182, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 333, 188, 60, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 571, 18, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 598, 36, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 38, 40, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 199, 15, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 111, 42, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 300, 12, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 470, 11, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 400, 21, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 230, 188, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 522, 181, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 9, 115, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 50, 111, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2162, 592, 79, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 333, 189, 3, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(34896, 332, 190, 128, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(34890, 335, 189, 92, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2123, 340, 190, 60, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2086, 169, 147, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 464, 138, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 443, 122, 0, 8017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 182, 121, 0, 8017));
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

