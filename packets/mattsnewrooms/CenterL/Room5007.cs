using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5007 : Room
  {
        public Room5007()
            : base(5007, "Leinster")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 119, 54, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(35304, 535, 53, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 141, 158, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 210, 122, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 179, 138, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 101, 170, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 281, 280, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 239, 86, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 242, 313, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 15, 176, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 94, 53, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 170, 28, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 148, 64, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 186, 96, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 73, 127, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 65, 145, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 408, 85, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 539, 160, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 328, 268, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 580, 171, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 461, 135, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 497, 153, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 414, 313, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 624, 174, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 483, 25, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 646, 48, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 499, 59, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 468, 90, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 573, 121, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 562, 136, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 39, 58, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 98, 56, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 148, 57, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 508, 56, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 555, 56, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 607, 56, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 50, 167, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 634, 174, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(7904, 163, 137, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(40672, 490, 133, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(7905, 91, 173, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(40673, 581, 176, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 375, 281, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 315, 270, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 353, 247, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 343, 292, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 77, 99, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 568, 60, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 609, 83, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 132, 49, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 349, 280, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 320, 296, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(200, 324, 308, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 337, 302, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 350, 308, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 301, 314, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 330, 344, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 58, 173, 0, 5007));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 431, 110, 0, 5007));
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

