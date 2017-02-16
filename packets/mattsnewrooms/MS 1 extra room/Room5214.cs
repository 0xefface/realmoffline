using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5214 : Room
  {
        public Room5214()
            : base(5214, "Murias")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.Left;
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 427, 3, 65437, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 3, 228, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 547, 2, 65437, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 168, 97, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 54, 213, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 5, 211, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 62, 201, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 28, 198, 65516, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 65528, 239, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 123, 128, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 158, 104, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 404, 119, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 481, 121, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 643, 185, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 53, 229, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 564, 115, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 482, 116, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 322, 291, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 609, 173, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 84, 229, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 95, 113, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 483, 268, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 134, 267, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(25, 544, 268, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 546, 241, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 576, 267, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 564, 85, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 459, 81, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 625, 130, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 313, 0, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 479, 0, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 354, 0, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 180, 12, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 68, 13, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 111, 60, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 65497, 157, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 76, 115, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 278, 289, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 614, 117, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(32871, 590, 161, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 621, 165, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 572, 157, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 617, 159, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 71, 208, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 204, 91, 0, 5214));
          this.AddRoomDecoration(RoomDecoration.FromCode(121, 60, 115, 0, 5214));
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

