using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5216 : Room
  {
        public Room5216()
            : base(5216, "Murias")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.Right;
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 597, 337, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 363, 170, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 460, 167, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 451, 194, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 256, 5, 65437, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 54, 1, 65437, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(2953, 1, 162, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 583, 88, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 157, 107, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 198, 226, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 306, 177, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 290, 201, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 169, 191, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 43, 167, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 366, 194, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 138, 226, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 245, 195, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 149, 196, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 398, 163, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 623, 312, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 238, 225, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 98, 100, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 270, 99, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 540, 5, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 539, 32, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 487, 266, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 143, 87, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 186, 109, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 442, 81, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(25, 76, 91, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 225, 129, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 530, 86, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 172, 2, 65535, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 392, 1, 65535, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(25, 370, 17, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 474, 51, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32793, 381, 54, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 455, 138, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 123, 202, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 68, 154, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 104, 171, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 130, 140, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 330, 193, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32793, 280, 214, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 295, 1, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32793, 365, 8, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 103, 281, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 588, 189, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 601, 184, 0, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 626, 213, 65535, 5216));
          this.AddRoomDecoration(RoomDecoration.FromCode(32952, 281, 107, 0, 5216));
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

