using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5611 : Room
  {
        public Room5611()
            : base(5611, "Pedantic Pilfery")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 176, 17, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 264, 33, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 241, 43, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 402, 18, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 503, 34, 40, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 193, 128, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 175, 158, 65506, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 242, 204, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 263, 218, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 123, 174, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 341, 200, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 121, 154, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 320, 202, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 225, 179, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 548, 110, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 182, 208, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 346, 150, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 281, 151, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 193, 134, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 329, 177, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 282, 146, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2733, 312, 202, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(35381, 703, 148, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 462, 180, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 133, 193, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 332, 48, 0, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 236, 50, 15, 5611));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 554, 16, 65386, 5611));
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

