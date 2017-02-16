using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5009 : Room
  {
        public Room5009()
            : base(5009, "Leinster")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 119, 54, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(35304, 535, 53, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 568, 64, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 101, 33, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 57, 59, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 326, 35, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 437, 8, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 536, 38, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 405, 25, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 286, 22, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 332, 50, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 144, 38, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 466, 43, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 618, 57, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 109, 59, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 21, 59, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 544, 70, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 537, 74, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 571, 68, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 87, 277, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 572, 283, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 46, 335, 0, 5009));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 602, 335, 0, 5009));
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

