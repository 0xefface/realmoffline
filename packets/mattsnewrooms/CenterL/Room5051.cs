using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5051 : Room
  {
        public Room5051()
            : base(5051, "Leinster")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 120, 11, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 78, 36, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 11, 82, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 189, 26, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 128, 100, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 449, 38, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 70, 117, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 299, 3, 65496, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 153, 76, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 116, 144, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 102, 157, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(35481, 595, 212, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 284, 114, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(35482, 584, 133, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 321, 231, 65496, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 197, 75, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 548, 90, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 188, 150, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 436, 69, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 340, 10, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2754, 477, 182, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2751, 468, 171, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2752, 456, 160, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2751, 611, 226, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 497, 271, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 426, 267, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 421, 108, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2754, 553, 207, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2753, 573, 212, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2752, 592, 220, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 583, 213, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 542, 186, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 464, 216, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 333, 199, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 477, 186, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 213, 240, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 29, 248, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 475, 148, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 651, 244, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 82, 276, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 615, 276, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 196, 100, 65496, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 396, 187, 65496, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2751, 530, 201, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2753, 514, 193, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2752, 493, 187, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2754, 447, 152, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2753, 438, 141, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(35525, 443, 125, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(35525, 430, 101, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(35523, 438, 114, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(35526, 420, 75, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(35523, 425, 90, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(35523, 453, 137, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 301, 61, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 325, 122, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 414, 204, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 344, 200, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 307, 12, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(35482, 477, 132, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(35481, 441, 87, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(35481, 482, 154, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(35482, 512, 171, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(35482, 562, 197, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(35481, 510, 182, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 212, 208, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 212, 233, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 420, 129, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 620, 227, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 559, 211, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 498, 192, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 468, 166, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 345, 290, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 310, 290, 65496, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(35523, 413, 64, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32900, 245, 72, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 428, 327, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 250, 326, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 510, 349, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 184, 350, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 103, 351, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 30, 350, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 136, 322, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 70, 128, 65496, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 532, 322, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 222, 106, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 164, 139, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 33, 164, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 133, 134, 65496, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 64, 210, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 120, 135, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 76, 229, 0, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 253, 140, 65496, 5051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 602, 348, 0, 5051));
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

