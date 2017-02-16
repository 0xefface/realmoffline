using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6400 : Room
  {
        public Room6400()
            : base(6400, "Silverbrook Charms Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 134, 60, 0, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 325, 275, 0, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2020, 170, 28, 0, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 243, 6, 0, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 346, 50, 0, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 435, 117, 0, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 228, 116, 0, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 101, 207, 0, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2110, 82, 114, 0, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 329, 114, 0, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2147, 65529, 379, 0, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2125, 333, 115, 20, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2143, 61, 208, 65526, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2142, 61, 208, 20, 6400));
          this.AddRoomDecoration(RoomDecoration.FromCode(2133, 77, 115, 20, 6400));
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

