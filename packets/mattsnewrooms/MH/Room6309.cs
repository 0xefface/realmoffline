using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6309 : Room
  {
        public Room6309()
            : base(6309, "Magical Monmouth Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 318, 328, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2020, 170, 27, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 243, 7, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 338, 49, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2111, 540, 96, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 329, 116, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 225, 49, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 434, 49, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2104, 32, 229, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2125, 323, 329, 65, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 227, 148, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 434, 146, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 537, 206, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2124, 332, 117, 20, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2142, 65499, 230, 50, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(34914, 564, 97, 17, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2162, 617, 126, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 28, 121, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2129, 353, 184, 65516, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(34898, 249, 179, 65516, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 533, 207, 45, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 227, 133, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 434, 131, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 207, 147, 15, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 412, 145, 15, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 254, 202, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 368, 202, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(7904, 199, 204, 0, 6309));
          this.AddRoomDecoration(RoomDecoration.FromCode(40672, 417, 205, 0, 6309));
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

