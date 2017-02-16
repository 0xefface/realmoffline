using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8100 : Room
  {
        public Room8100()
            : base(8100, "The Chapel Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2004, 567, 5, 55, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 294, 4, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 420, 4, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 172, 3, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 509, 2, 7, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 148, 2, 8, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2016, 94, 4, 55, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 156, 126, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 288, 129, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 423, 123, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 573, 126, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 282, 140, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2048, 571, 143, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 325, 295, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 151, 138, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 131, 74, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 416, 138, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2558, 456, 131, 20, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2558, 322, 132, 20, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2558, 192, 132, 20, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2557, 625, 136, 20, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 274, 62, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 376, 61, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 525, 80, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 407, 94, 0, 8100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 241, 94, 0, 8100));
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

