using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7010 : Room
  {
        public Room7010()
            : base(7010, "Bloodforge Armory")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 349, 202, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 217, 186, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 541, 6, 65474, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2958, 85, 329, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 375, 20, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 428, 20, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 404, 26, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 430, 66, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 378, 64, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 44, 183, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 67, 181, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 278, 28, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 77, 21, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 483, 178, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 7, 25, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 238, 88, 30, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 56, 61, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 179, 27, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 224, 58, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2695, 264, 123, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 126, 182, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 370, 95, 65476, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 20, 154, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 33, 161, 20, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 383, 162, 20, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2710, 259, 76, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 631, 87, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 349, 186, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 383, 185, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 312, 190, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 460, 183, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 279, 192, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 253, 196, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 109, 186, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 6, 184, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 82, 182, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 594, 20, 65474, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 557, 334, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 76, 334, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 407, 193, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(35726, 547, 329, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 26, 174, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 118, 157, 0, 7010));
          this.AddRoomDecoration(RoomDecoration.FromCode(94, 335, 8, 65476, 7010));
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

