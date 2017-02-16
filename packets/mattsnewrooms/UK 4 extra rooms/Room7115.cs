using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7115 : Room
  {
        public Room7115()
            : base(7115, "Gardens R Usk")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.SnowyDesert;
          this.BlockedRoomExits = BlockedExits.UpRight;
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 251, 73, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(35527, 621, 185, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 565, 71, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 325, 78, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 450, 78, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 243, 243, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 103, 251, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(6020, 612, 321, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(38774, 213, 206, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(38932, 543, 246, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2631, 274, 86, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 359, 87, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2634, 550, 87, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 447, 87, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(6142, 274, 94, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(6142, 490, 92, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(6142, 408, 93, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(6142, 557, 91, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 299, 188, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 299, 192, 12, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 542, 195, 13, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 541, 186, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(6018, 9, 191, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(6015, 242, 230, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(6041, 109, 252, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(6015, 636, 240, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(6019, 191, 229, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(6014, 630, 242, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(38788, 613, 242, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2762, 198, 141, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(6032, 65525, 155, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(35529, 620, 138, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(38919, 7, 146, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2760, 197, 194, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2759, 198, 223, 65526, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(38923, 36, 172, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(38809, 95, 260, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(35530, 621, 231, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(6004, 591, 225, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(6040, 88, 216, 0, 7115));
          this.AddRoomDecoration(RoomDecoration.FromCode(38808, 81, 221, 0, 7115));
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

