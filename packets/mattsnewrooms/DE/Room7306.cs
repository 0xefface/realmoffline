using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7306 : Room
  {
        public Room7306()
            : base(7306, "Nosh Shop")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 170, 44, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 425, 152, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 311, 26, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 93, 71, 37, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 137, 159, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2621, 620, 50, 22, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2505, 468, 14, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2710, 362, 47, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 333, 83, 65470, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 611, 184, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 10, 139, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 224, 89, 48, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(35370, 499, 81, 48, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 441, 200, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 203, 85, 48, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 551, 203, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 336, 66, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 189, 170, 65529, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 517, 158, 20, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(35483, 509, 145, 65506, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 211, 170, 53, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 599, 182, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 380, 182, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 162, 215, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 525, 82, 65470, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 82, 210, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(32793, 21, 8, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 96, 259, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 553, 35, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2697, 381, 89, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 603, 40, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 592, 30, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2624, 577, 50, 17, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 44, 4, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 65517, 58, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(25, 73, 60, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 193, 199, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 422, 173, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 116, 206, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 194, 292, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 480, 184, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 65528, 141, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(1508, 548, 187, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(34276, 116, 22, 65364, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 631, 182, 0, 7306));
          this.AddRoomDecoration(RoomDecoration.FromCode(35370, 608, 65, 48, 7306));
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

