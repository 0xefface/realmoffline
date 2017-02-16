using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5204 : Room
  {
        public Room5204()
            : base(5204, "Tasty Morsels")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 250, 39, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 340, 68, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 412, 65, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 552, 47, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2613, 457, 187, 100, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 15, 178, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2613, 325, 164, 100, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 323, 70, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 335, 72, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2628, 387, 80, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 478, 210, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 290, 173, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 583, 171, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 290, 167, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 509, 240, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 395, 219, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 31, 195, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 520, 224, 120, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 628, 234, 120, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 631, 223, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 618, 234, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 10, 167, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 65529, 234, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 25, 123, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 174, 13, 65485, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65525, 35, 65437, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 17, 16, 65456, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 641, 245, 120, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 462, 234, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2958, 77, 172, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2958, 58, 148, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2958, 332, 221, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2958, 372, 223, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 12, 132, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 113, 186, 65437, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 566, 198, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 495, 183, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2652, 560, 49, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 582, 52, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 26, 188, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 568, 238, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 631, 325, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 573, 324, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 620, 224, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 25, 314, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 609, 322, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 443, 241, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 521, 274, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 162, 292, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 193, 192, 0, 5204));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 81, 264, 0, 5204));
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

