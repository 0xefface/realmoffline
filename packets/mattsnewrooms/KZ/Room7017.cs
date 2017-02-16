using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7017 : Room
  {
        public Room7017()
            : base(7017, "Elise's Provisions")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 289, 52, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 650, 306, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 96, 209, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 359, 24, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 38, 153, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 669, 103, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 50, 214, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 255, 31, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 58, 47, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 161, 38, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 114, 63, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 81, 71, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 261, 55, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(35722, 612, 328, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(35722, 541, 346, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 12, 209, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 1, 211, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 22, 181, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 169, 164, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 144, 146, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 341, 129, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 366, 147, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2798, 381, 110, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2794, 391, 59, 65496, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2710, 381, 59, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(94, 335, 13, 65476, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(164, 497, 14, 65471, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 490, 2, 65476, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 563, 40, 65486, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 24, 215, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 76, 215, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 111, 208, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 353, 191, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 395, 184, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 181, 197, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 111, 202, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 628, 308, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 579, 178, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 583, 185, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 595, 146, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 615, 128, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 458, 20, 65466, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 650, 187, 0, 7017));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 619, 233, 0, 7017));
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

