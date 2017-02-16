using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7004 : Room
  {
        public Room7004()
            : base(7004, "The Learning Emporium")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2505, 341, 42, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2506, 416, 84, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2506, 513, 73, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 379, 19, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 153, 146, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 734, 76, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 507, 174, 65507, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 195, 236, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 198, 230, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2794, 383, 107, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(35482, 504, 187, 65461, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2802, 388, 110, 18, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2613, 567, 183, 65500, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 637, 277, 48, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 223, 179, 60, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 247, 223, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2613, 211, 157, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(123, 618, 274, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 149, 219, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(164, 31, 86, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 471, 88, 65445, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 427, 94, 42, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 255, 157, 60, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 471, 173, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 427, 87, 40, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 111, 205, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 558, 270, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 468, 271, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(94, 329, 17, 65470, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 0, 103, 0, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 636, 192, 70, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 579, 215, 70, 7004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2506, 608, 35, 0, 7004));
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

