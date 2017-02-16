using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7311 : Room
  {
        public Room7311()
            : base(7311, "Birger's Barbery")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 150, 16, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 200, 204, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 195, 192, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2524, 47, 192, 150, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 207, 32, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 415, 206, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 409, 27, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 310, 36, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 311, 192, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(35371, 65498, 307, 252, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2585, 238, 132, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2585, 381, 135, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 218, 131, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 361, 132, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 611, 21, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 28, 211, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 4, 217, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 434, 192, 80, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 416, 192, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 450, 195, 30, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 226, 196, 30, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2601, 65530, 137, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2605, 231, 43, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2605, 375, 41, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2605, 415, 39, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 536, 15, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 49, 215, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 36, 228, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 561, 11, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 506, 1, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 579, 40, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 606, 82, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 247, 203, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 459, 198, 0, 7311));
          this.AddRoomDecoration(RoomDecoration.FromCode(32832, 364, 191, 0, 7311));
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

