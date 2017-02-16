using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8006 : Room
  {
        public Room8006()
            : base(8006, "Spiked Glove Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 180, 33, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 382, 17, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(34989, 308, 175, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 79, 38, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 91, 221, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 463, 27, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 563, 282, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2119, 571, 283, 3, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2119, 571, 283, 65, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2139, 21, 222, 45, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 147, 145, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2121, 573, 283, 32, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 420, 282, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 385, 83, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 442, 69, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 496, 83, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 13, 62, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 115, 108, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 11, 126, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2120, 434, 283, 60, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 569, 43, 20, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 625, 45, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2041, 28, 163, 0, 8006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 447, 200, 0, 8006));
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

