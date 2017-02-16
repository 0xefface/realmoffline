using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5310 : Room
  {
        public Room5310()
            : base(5310, "Volzer's Weapons")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 181, 16, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 167, 20, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 411, 149, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 441, 143, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2522, 426, 157, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 65482, 177, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 435, 217, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 370, 155, 11, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 56, 216, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2710, 153, 166, 112, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2803, 178, 120, 40, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 250, 166, 10, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 379, 225, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 73, 306, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 571, 43, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2621, 500, 151, 17, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 65370, 151, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 462, 8, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 568, 1, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 538, 30, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 526, 34, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 339, 211, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 363, 226, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 465, 219, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(32952, 414, 227, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 440, 211, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 483, 202, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2807, 159, 112, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 250, 160, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 77, 272, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 497, 284, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 534, 58, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 579, 28, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(35503, 96, 131, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(35500, 325, 220, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(35501, 285, 185, 0, 5310));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 348, 221, 0, 5310));
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

