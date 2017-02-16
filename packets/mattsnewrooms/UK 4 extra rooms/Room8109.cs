using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8109 : Room
  {
        public Room8109()
            : base(8109, "The Best Pick Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 523, 165, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 322, 12, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 67, 6, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 263, 10, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2392, 73, 122, 65486, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2391, 516, 122, 65486, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2390, 172, 109, 65486, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(34917, 574, 183, 30, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2394, 7, 132, 65486, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2390, 412, 159, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(34916, 575, 178, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2162, 92, 76, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2162, 19, 88, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 485, 76, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 560, 86, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 164, 75, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 413, 75, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2105, 488, 287, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2393, 595, 134, 65486, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 513, 7, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 410, 2, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2393, 631, 140, 65486, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 166, 1, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 599, 34, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 9, 29, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2395, 353, 109, 65486, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2395, 233, 109, 65486, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 639, 218, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 564, 190, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 489, 181, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 489, 173, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 592, 205, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 443, 170, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 391, 159, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 402, 163, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 411, 169, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 425, 176, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 441, 178, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 455, 181, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 468, 184, 0, 8109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 483, 188, 0, 8109));
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

