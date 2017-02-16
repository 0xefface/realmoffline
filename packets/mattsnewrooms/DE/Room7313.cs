using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7313 : Room
  {
        public Room7313()
            : base(7313, "Preparatory Prestidigitation")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 86, 43, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 133, 50, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 112, 61, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 275, 32, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 380, 65523, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(35722, 4, 131, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 37, 188, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 340, 141, 80, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2544, 223, 172, 20, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2541, 213, 169, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 101, 148, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 154, 157, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 101, 164, 20, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 153, 172, 20, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 64, 25, 65437, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 191, 71, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 47, 213, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 9, 202, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 30, 202, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 4, 185, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 366, 87, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2752, 158, 216, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2757, 366, 56, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2754, 160, 162, 48, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2751, 156, 166, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 183, 218, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 185, 164, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 367, 188, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2757, 367, 138, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2758, 183, 113, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2757, 182, 61, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 379, 187, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(186, 334, 197, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 182, 164, 103, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 114, 153, 103, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 283, 196, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 65500, 172, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2793, 270, 74, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(35570, 285, 80, 19, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 132, 211, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 159, 218, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 30, 217, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 239, 212, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 190, 220, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 374, 194, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 83, 219, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 269, 210, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 59, 219, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 219, 218, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 110, 216, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 126, 220, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 122, 199, 0, 7313));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 190, 203, 0, 7313));
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

