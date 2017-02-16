using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8307 : Room
  {
        public Room8307()
            : base(8307, "Clothes Make the Elf Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 69, 85, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 512, 327, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 99, 216, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 186, 273, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2020, 170, 25, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 243, 6, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 346, 49, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2136, 38, 217, 47, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 514, 328, 63, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2041, 43, 158, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 330, 207, 33, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 383, 121, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 573, 167, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 195, 142, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 396, 140, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 329, 207, 3, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 328, 206, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 225, 208, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 431, 207, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 277, 122, 0, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 56, 158, 14, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 625, 171, 14, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2555, 229, 142, 16, 8307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2555, 430, 140, 16, 8307));
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

