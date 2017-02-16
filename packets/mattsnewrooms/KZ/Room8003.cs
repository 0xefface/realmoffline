using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8003 : Room
  {
        public Room8003()
            : base(8003, "Wards of War Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 134, 60, 0, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 272, 277, 0, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2020, 170, 28, 0, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 243, 6, 0, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 346, 50, 0, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 98, 206, 0, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2110, 82, 112, 0, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 329, 113, 65516, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2147, 65529, 379, 0, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2125, 334, 164, 50, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2143, 54, 206, 65524, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2142, 54, 206, 18, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2133, 77, 134, 40, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 204, 103, 0, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 371, 101, 0, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 246, 76, 0, 8003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 413, 74, 0, 8003));
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

