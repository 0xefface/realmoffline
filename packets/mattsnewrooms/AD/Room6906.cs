using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6906 : Room
  {
        public Room6906()
            : base(6906, "Northlander Weaponry Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 205, 17, 0, 6906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 308, 8, 0, 6906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 410, 2, 0, 6906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 570, 177, 0, 6906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 102, 23, 0, 6906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 16, 50, 0, 6906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 495, 11, 0, 6906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 433, 169, 0, 6906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2119, 440, 170, 33, 6906));
          this.AddRoomDecoration(RoomDecoration.FromCode(34888, 434, 170, 60, 6906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2119, 440, 170, 4, 6906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2139, 20, 191, 15, 6906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 350, 61, 0, 6906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 124, 107, 0, 6906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 14, 122, 0, 6906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 71, 190, 0, 6906));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 332, 252, 0, 6906));
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

