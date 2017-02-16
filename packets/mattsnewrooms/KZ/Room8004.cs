using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8004 : Room
  {
        public Room8004()
            : base(8004, "Learning Emporium Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2338, 220, 55, 65486, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2339, 414, 55, 65486, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2339, 511, 70, 65486, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2339, 608, 85, 65486, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2338, 123, 69, 65486, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2338, 27, 133, 0, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2339, 705, 100, 65486, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2338, 65466, 98, 65486, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 511, 117, 0, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2119, 275, 120, 0, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2120, 302, 125, 0, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2147, 209, 128, 0, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(34916, 562, 139, 10, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(34907, 692, 208, 50, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2138, 382, 125, 0, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(34917, 563, 135, 30, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 462, 129, 0, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 576, 147, 0, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 696, 167, 0, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 410, 127, 0, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 534, 147, 0, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 102, 140, 0, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 65420, 176, 0, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 217, 122, 0, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 268, 129, 0, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 104, 126, 0, 8004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 38, 136, 0, 8004));
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

