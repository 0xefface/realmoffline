using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4045 : Room
  {
        public Room4045()
            : base(4045, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 515, 108, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 47, 105, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 305, 273, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 131, 213, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 145, 217, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 588, 320, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 143, 211, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 104, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 294, 311, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 177, 209, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(180, 288, 262, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 378, 118, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 430, 119, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 107, 108, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32920, 200, 117, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 332, 108, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(218, 26, 212, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32986, 25, 171, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(217, 84, 116, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32984, 26, 151, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(214, 69, 268, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(215, 207, 278, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32973, 64, 97, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32920, 14, 110, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 108, 290, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 101, 312, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 29, 171, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 37, 212, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 15, 212, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 25, 154, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 14, 171, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 43, 153, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 84, 118, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 53, 101, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 33, 103, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 9, 105, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 84, 255, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 150, 255, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 15, 326, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 20, 106, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 211, 117, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 230, 118, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 361, 119, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 119, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 407, 119, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 430, 119, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 119, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 463, 119, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(180, 153, 264, 0, 4045));
          this.AddRoomDecoration(RoomDecoration.FromCode(180, 136, 248, 0, 4045));
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

