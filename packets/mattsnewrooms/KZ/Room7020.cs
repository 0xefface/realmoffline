using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7020 : Room
  {
        public Room7020()
            : base(7020, "Mirror 'n Gear")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2749, 233, 2, 65437, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2749, 610, 5, 65437, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 14, 43, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 209, 32, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 51, 67, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(35370, 157, 103, 50, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 304, 19, 65446, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 660, 23, 65446, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 259, 1, 65478, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 9, 202, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 485, 2, 65446, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 492, 29, 65476, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 4, 226, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 118, 128, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 499, 22, 65461, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2244, 133, 218, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 112, 48, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(35370, 71, 66, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 159, 51, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 65518, 222, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 99, 222, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 93, 261, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(25, 604, 22, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 499, 260, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 568, 104, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 555, 232, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 482, 103, 0, 7020));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 412, 213, 0, 7020));
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

