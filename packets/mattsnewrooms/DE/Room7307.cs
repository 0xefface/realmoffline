using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7307 : Room
  {
        public Room7307()
            : base(7307, "Clothes Make the Elf")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 52, 37, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 134, 50, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 105, 61, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 95, 62, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 180, 74, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 272, 32, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(35370, 303, 58, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 380, 65523, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(35369, 188, 77, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(25, 327, 296, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 94, 271, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(32952, 59, 204, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2541, 216, 185, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 70, 164, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 157, 178, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 49, 206, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(32793, 45, 199, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 194, 233, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 480, 14, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 401, 157, 21, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2806, 82, 114, 10, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(35369, 370, 47, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2541, 387, 157, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 143, 245, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 230, 193, 21, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 71, 165, 4, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 157, 180, 4, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2794, 70, 112, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 26, 204, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 459, 168, 65516, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 195, 204, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 520, 266, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 410, 35, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 420, 185, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 108, 213, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 49, 220, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 463, 185, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 189, 234, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 231, 234, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 280, 206, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 245, 318, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 294, 322, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 147, 245, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 374, 206, 0, 7307));
          this.AddRoomDecoration(RoomDecoration.FromCode(35370, 436, 38, 0, 7307));
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

