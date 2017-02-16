using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7302 : Room
  {
        public Room7302()
            : base(7302, "Curses 'n Cures")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 66, 63, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 90, 67, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 77, 79, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 85, 200, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 74, 181, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 234, 49, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 461, 173, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2510, 324, 39, 65511, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 546, 203, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 140, 262, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 390, 228, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 498, 225, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 486, 191, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 65523, 115, 65466, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2800, 365, 167, 29, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 164, 186, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 477, 56, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 39, 208, 65516, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 45, 131, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 340, 206, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 189, 204, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2613, 144, 80, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2503, 371, 30, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(35382, 257, 220, 127, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(35382, 428, 193, 127, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 65506, 61, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 539, 12, 65414, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 47, 71, 65407, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 620, 7, 65491, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 14, 46, 65489, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 499, 53, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 484, 66, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2794, 352, 154, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(123, 411, 219, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 48, 27, 65499, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 544, 204, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 423, 223, 83, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 67, 44, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 517, 28, 65466, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 93, 262, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 136, 235, 0, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 417, 1, 65466, 7302));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 472, 254, 0, 7302));
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

