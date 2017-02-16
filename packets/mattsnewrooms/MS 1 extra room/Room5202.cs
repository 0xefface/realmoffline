using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5202 : Room
  {
        public Room5202()
            : base(5202, "Anvil and Pestle")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 39, 46, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 134, 61, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 85, 67, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 14, 210, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 275, 42, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 79, 168, 7, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 380, 65523, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 159, 233, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 504, 135, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 293, 2, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2752, 65526, 99, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 80, 165, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 146, 176, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 374, 215, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 166, 200, 115, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2753, 65526, 147, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 84, 121, 42, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 146, 177, 4, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2751, 65519, 201, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 434, 184, 23, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 184, 196, 115, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 371, 210, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 498, 202, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 113, 220, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 484, 222, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 480, 221, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 428, 205, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 135, 218, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 196, 238, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 448, 223, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 313, 202, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 12, 211, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 171, 236, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(32952, 397, 206, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2751, 156, 177, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2752, 157, 228, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2753, 451, 211, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2754, 159, 187, 63, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 183, 226, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 185, 173, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 247, 196, 115, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2758, 184, 123, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 14, 205, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 188, 230, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2701, 317, 239, 100, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(2710, 310, 244, 150, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(14, 185, 244, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(14, 83, 226, 0, 5202));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 360, 223, 0, 5202));
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

