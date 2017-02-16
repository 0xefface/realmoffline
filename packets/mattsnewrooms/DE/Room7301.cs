using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7301 : Room
  {
        public Room7301()
            : base(7301, "Broken Jug")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2508, 123, 77, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 274, 95, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 337, 96, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 424, 82, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 477, 62, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 357, 243, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 445, 184, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 532, 3, 65334, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 44, 190, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 45, 78, 10, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 332, 203, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 389, 193, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 310, 290, 65397, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 344, 205, 15, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 400, 196, 15, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 456, 187, 15, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 61, 197, 21, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 62, 82, 29, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(35369, 408, 155, 75, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 296, 242, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 15, 237, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 26, 243, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 339, 235, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2756, 226, 261, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 36, 256, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 302, 254, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(35369, 343, 167, 75, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2758, 223, 154, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(35369, 226, 185, 75, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 523, 230, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(32814, 319, 245, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 428, 241, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 508, 234, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2751, 196, 209, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2752, 199, 260, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2753, 203, 139, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2754, 200, 156, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2755, 225, 208, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(32793, 298, 309, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(32814, 518, 182, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 572, 8, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 553, 5, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(25, 590, 60, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 651, 169, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2808, 123, 116, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2798, 112, 117, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 83, 264, 0, 7301));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 65532, 269, 0, 7301));
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

