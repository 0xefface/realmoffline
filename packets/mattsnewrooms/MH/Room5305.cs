using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5305 : Room
  {
        public Room5305()
            : base(5305, "Eldest Inn")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2505, 341, 42, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2506, 416, 84, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2506, 508, 73, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 332, 25, 65386, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2735, 448, 95, 26, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 688, 75, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 462, 200, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 11, 211, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2700, 427, 245, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 551, 241, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 391, 188, 65521, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 310, 290, 65483, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(35481, 506, 188, 96, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 298, 79, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 395, 92, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 564, 246, 17, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 62, 236, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2596, 404, 208, 18, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2596, 314, 84, 18, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2596, 411, 97, 18, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 429, 98, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(35481, 392, 233, 96, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 635, 250, 48, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 30, 248, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 506, 114, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(123, 612, 250, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 432, 210, 60, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 23, 218, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 35, 195, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 604, 295, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 20, 259, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(35504, 281, 126, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 515, 215, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2957, 511, 294, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 493, 72, 65356, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 549, 280, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(35499, 499, 263, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 335, 57, 65386, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 321, 220, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 3, 241, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 27, 223, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 37, 269, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 261, 31, 65436, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 27, 121, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 247, 21, 65436, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(35481, 258, 195, 96, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 2, 87, 0, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 279, 20, 65476, 5305));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 265, 24, 65476, 5305));
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

