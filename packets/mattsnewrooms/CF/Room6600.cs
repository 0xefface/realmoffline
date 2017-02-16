using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6600 : Room
  {
        public Room6600()
            : base(6600, "Necromancer's Wares Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 318, 328, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2020, 170, 27, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 243, 7, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 338, 49, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 422, 8, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2111, 540, 96, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 329, 116, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 225, 49, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 434, 49, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2104, 32, 229, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2125, 323, 329, 65, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 195, 149, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 390, 145, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 537, 206, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2124, 332, 117, 20, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2142, 65499, 230, 50, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(34914, 564, 97, 17, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2162, 617, 126, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 28, 121, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2129, 360, 64, 65396, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(34898, 250, 55, 65391, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 533, 207, 45, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 189, 160, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 384, 161, 0, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2558, 229, 150, 16, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(2558, 424, 148, 14, 6600));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 310, 206, 0, 6600));
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

