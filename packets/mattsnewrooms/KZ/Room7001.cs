using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7001 : Room
  {
        public Room7001()
            : base(7001, "Grand Gear")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 235, 215, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 65515, 94, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 582, 2, 65437, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 590, 2, 65437, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 506, 31, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 307, 45, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 408, 38, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 169, 212, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 247, 50, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 209, 219, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 265, 180, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 473, 166, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 163, 179, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 453, 189, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 281, 152, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 489, 138, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 179, 151, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 557, 185, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 633, 322, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 625, 135, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 511, 183, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 639, 104, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 270, 217, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 188, 45, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 208, 216, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 233, 220, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 300, 213, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 250, 216, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 198, 73, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 349, 59, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 289, 73, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 495, 60, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 268, 167, 0, 7001));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 517, 167, 0, 7001));
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

