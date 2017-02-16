using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5082 : Room
  {
        public Room5082()
            : base(5082, "Bridal Mezzanine")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 260, 51, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 251, 58, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 379, 66, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 359, 41, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 360, 49, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 263, 41, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 370, 58, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 507, 84, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 110, 2, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(2749, 380, 45, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(35517, 243, 43, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 71, 28, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 547, 23, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 240, 35, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 304, 1, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 310, 3, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 553, 106, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 49, 52, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(2957, 462, 186, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(2958, 448, 177, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 98, 51, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 155, 50, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 505, 53, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 567, 55, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 632, 56, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 453, 54, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 384, 35, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 3, 54, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 260, 1, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 435, 91, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 389, 77, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 234, 78, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 245, 68, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 185, 94, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 411, 84, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 208, 87, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 603, 107, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 578, 108, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 461, 96, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 107, 106, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 488, 98, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 510, 101, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 533, 103, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 133, 103, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 157, 99, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 322, 153, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 291, 185, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(35726, 198, 176, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(35725, 164, 186, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 363, 181, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 343, 181, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 320, 179, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 306, 180, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 267, 181, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 291, 179, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 249, 184, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 383, 184, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 269, 169, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 350, 171, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 63, 69, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 567, 61, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 112, 257, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 543, 251, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 312, 266, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 292, 273, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 73, 98, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 20, 109, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 562, 88, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 618, 100, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 38, 319, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 102, 322, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 609, 319, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 547, 320, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32828, 491, 323, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32828, 163, 321, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32828, 225, 320, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32828, 427, 320, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 378, 321, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 15, 119, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 223, 83, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 40, 118, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 84, 110, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 65, 116, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 628, 109, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 204, 49, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 418, 54, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 133, 87, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 62, 306, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 580, 306, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 460, 306, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 182, 306, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 192, 172, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 442, 168, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 343, 185, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 490, 215, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 150, 217, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 4, 118, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 621, 111, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 541, 111, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 89, 112, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 390, 69, 0, 5082));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 231, 71, 0, 5082));
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

