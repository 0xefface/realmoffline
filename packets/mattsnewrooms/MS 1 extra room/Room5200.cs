using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5200 : Room
  {
        public Room5200()
            : base(5200, "Thresher's Roost")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 150, 16, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2613, 65489, 169, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(35383, 65490, 206, 150, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2524, 47, 192, 150, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 207, 32, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2617, 229, 52, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 412, 32, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2617, 400, 46, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2527, 309, 53, 50, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2618, 308, 93, 50, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 317, 193, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 659, 112, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2549, 204, 150, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 620, 111, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2558, 410, 146, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 28, 211, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2700, 280, 237, 150, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 434, 192, 80, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 421, 191, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 444, 192, 30, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 226, 194, 30, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 193, 193, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 200, 204, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 415, 206, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2549, 411, 148, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2558, 206, 147, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 609, 87, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 592, 148, 0, 5200));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 19, 266, 0, 5200));
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

