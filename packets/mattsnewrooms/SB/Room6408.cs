using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6408 : Room
  {
        public Room6408()
            : base(6408, "Look Your Best Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 69, 85, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 512, 327, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 99, 216, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 186, 273, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2020, 170, 25, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 243, 6, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 346, 49, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2136, 38, 217, 47, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 514, 328, 63, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2080, 53, 124, 65516, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 54, 137, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 594, 151, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 630, 137, 65516, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 240, 118, 65516, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 421, 118, 65516, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 219, 135, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 400, 135, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 225, 208, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 431, 207, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 277, 122, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 383, 121, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 328, 206, 0, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 329, 207, 3, 6408));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 330, 207, 33, 6408));
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

