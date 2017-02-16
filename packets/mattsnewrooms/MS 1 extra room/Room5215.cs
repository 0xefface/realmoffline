using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5215 : Room
  {
        public Room5215()
            : base(5215, "Murias")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.Down;
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 613, 362, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2605, 401, 45, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(35370, 265, 55, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 90, 55, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2517, 312, 8, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2505, 56, 7, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2528, 209, 1, 65526, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2528, 144, 1, 65526, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2529, 169, 9, 65496, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 237, 118, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 112, 121, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 140, 175, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 29, 158, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2528, 412, 9, 10, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2606, 181, 55, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 375, 164, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 156, 147, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 67, 48, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 391, 136, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 18, 139, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 65534, 197, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 116, 201, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 223, 200, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 170, 202, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 27, 216, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 65, 10, 65361, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2605, 174, 55, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 221, 213, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 130, 213, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 390, 185, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 433, 185, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 398, 196, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 436, 196, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 523, 360, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 45, 365, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 146, 361, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 251, 363, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 428, 362, 0, 5215));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 341, 363, 0, 5215));
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

