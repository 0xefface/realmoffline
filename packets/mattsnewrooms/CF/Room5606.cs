using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5606 : Room
  {
        public Room5606()
            : base(5606, "Come and Get It")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 359, 70, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 271, 72, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 208, 48, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 497, 248, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 618, 226, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2541, 416, 194, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2613, 306, 65, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 149, 206, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 549, 235, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 502, 51, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2953, 570, 238, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 150, 193, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 590, 253, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 272, 57, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 491, 195, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 658, 57, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 384, 184, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 320, 175, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2556, 427, 202, 22, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2557, 383, 187, 8, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2557, 320, 178, 8, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2613, 430, 85, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 24, 1, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 90, 10, 2, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 36, 17, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 61, 11, 65494, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 112, 1, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2732, 409, 235, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(35499, 196, 103, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2731, 451, 235, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2733, 260, 211, 0, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2734, 408, 181, 65480, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2805, 312, 210, 98, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(2794, 306, 192, 70, 5606));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 412, 263, 0, 5606));
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

