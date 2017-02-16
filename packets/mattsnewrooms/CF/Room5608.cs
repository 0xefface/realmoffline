using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5608 : Room
  {
        public Room5608()
            : base(5608, "Take It or Leave It")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 150, 16, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2613, 65489, 169, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(35383, 65490, 206, 150, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2524, 47, 192, 150, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 207, 32, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2617, 229, 52, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 412, 32, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2617, 400, 46, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2527, 309, 53, 50, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2618, 308, 93, 50, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 271, 164, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 170, 199, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 287, 136, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 481, 202, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 522, 73, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 602, 24, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 517, 92, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 434, 192, 80, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 421, 191, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 444, 192, 30, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(35482, 194, 197, 30, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(35483, 242, 195, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 242, 199, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 413, 204, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 478, 113, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 560, 3, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2244, 23, 229, 56, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(2104, 26, 228, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 65469, 270, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 138, 222, 0, 5608));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 473, 210, 0, 5608));
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

