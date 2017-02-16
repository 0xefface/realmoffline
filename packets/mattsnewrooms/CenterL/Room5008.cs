using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5008 : Room
  {
        public Room5008()
            : base(5008, "Rampart Wall")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.Up;
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 608, 110, 110, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 511, 102, 100, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 91, 98, 100, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 302, 84, 100, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 430, 84, 100, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 174, 84, 100, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 65521, 98, 100, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2757, 55, 110, 6, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2761, 544, 111, 10, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2752, 517, 159, 110, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(35527, 58, 154, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 57, 155, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 55, 104, 50, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2753, 520, 103, 6, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(35529, 58, 110, 10, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 542, 155, 105, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(35528, 59, 105, 55, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2751, 517, 152, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 544, 154, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 562, 69, 65486, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 53, 68, 65486, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 145, 63, 65486, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 466, 64, 65486, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 113, 98, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 302, 154, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 342, 63, 65486, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 228, 138, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 362, 133, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 310, 290, 65486, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 200, 84, 65486, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 410, 83, 65486, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 354, 147, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 235, 155, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 352, 155, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 262, 146, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 395, 152, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 205, 150, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 299, 149, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 179, 144, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32828, 420, 140, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 78, 148, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 591, 149, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 552, 141, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 8, 170, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 609, 168, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 546, 186, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 57, 187, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 65512, 181, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 628, 179, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 310, 178, 0, 5008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 492, 104, 0, 5008));
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

