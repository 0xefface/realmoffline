using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7011 : Room
  {
        public Room7011()
            : base(7011, "Bloodspot Tavern")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(35468, 46, 103, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 137, 198, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 211, 206, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 118, 142, 65516, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 190, 22, 65521, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 294, 35, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 233, 62, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 101, 74, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 189, 142, 70, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 177, 142, 65516, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 217, 169, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 5, 27, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 104, 37, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 257, 193, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 133, 42, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 89, 211, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 31, 64, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 56, 142, 65516, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 80, 201, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 606, 100, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 195, 196, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(35722, 65520, 336, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 618, 329, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 658, 305, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 152, 207, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 29, 206, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 104, 170, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 192, 149, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 131, 150, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 69, 150, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(94, 339, 13, 65476, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 566, 96, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32917, 338, 15, 65456, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 545, 279, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 433, 68, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 590, 87, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 552, 159, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 622, 240, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 544, 111, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 622, 198, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 622, 138, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 633, 166, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 640, 233, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 569, 167, 0, 7011));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 625, 243, 0, 7011));
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

