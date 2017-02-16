using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8022 : Room
  {
        public Room8022()
            : base(8022, "Battling Mage Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2116, 117, 130, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 345, 99, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 328, 207, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2020, 167, 28, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 242, 6, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 346, 49, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2111, 560, 130, 65516, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 328, 109, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 217, 52, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 449, 52, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2148, 65405, 303, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2125, 331, 207, 65, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(34911, 610, 188, 50, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2130, 331, 190, 100, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 494, 281, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 167, 54, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2142, 431, 281, 45, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2048, 499, 112, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2047, 84, 109, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 100, 81, 0, 8022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 552, 84, 0, 8022));
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

