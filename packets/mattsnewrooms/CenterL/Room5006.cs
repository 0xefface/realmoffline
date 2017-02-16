using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5006 : Room
  {
        public Room5006()
            : base(5006, "Councillary")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.Up;
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 175, 54, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 428, 54, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 706, 54, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 109, 12, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 607, 14, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 318, 25, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 34, 77, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 25, 92, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32889, 570, 92, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 543, 69, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 451, 47, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 33, 55, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 110, 75, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 166, 84, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 292, 68, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(200, 549, 97, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2104, 152, 186, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 138, 193, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 52, 195, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 16, 85, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 150, 191, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 204, 185, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 115, 196, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 34, 126, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 112, 67, 0, 5006));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 137, 104, 0, 5006));
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

