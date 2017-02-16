using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5406 : Room
  {
        public Room5406()
            : base(5406, "Shop of Defense")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 65, 35, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 123, 44, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 88, 53, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 262, 26, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 545, 187, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 380, 170, 65516, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 430, 204, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 503, 204, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2696, 131, 111, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 497, 5, 65466, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2503, 386, 6, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 492, 31, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 83, 184, 65516, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 275, 69, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 382, 186, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 320, 154, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 500, 147, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 85, 157, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 295, 136, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 74, 138, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 475, 129, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 171, 57, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 126, 52, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 435, 45, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 10, 199, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 95, 204, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 50, 200, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 12, 210, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 366, 195, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 26, 188, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 369, 179, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 639, 4, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 677, 36, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 623, 58, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 683, 101, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 586, 148, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 595, 145, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 482, 169, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 640, 171, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 612, 174, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 624, 203, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 617, 190, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 604, 180, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 600, 151, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(2953, 652, 319, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 601, 332, 0, 5406));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 188, 237, 0, 5406));
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

