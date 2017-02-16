using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5205 : Room
  {
        public Room5205()
            : base(5205, "Murias Armorers")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 5, 28, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 70, 39, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 45, 50, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 154, 147, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 45, 148, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 209, 20, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 425, 137, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 393, 190, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 511, 183, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 2, 199, 65516, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 21, 226, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 102, 221, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2696, 327, 104, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(35370, 218, 52, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2503, 342, 2, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 56, 167, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 446, 27, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(35370, 128, 66, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(35370, 404, 48, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 500, 191, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 179, 165, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 450, 155, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 632, 20, 65496, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 353, 223, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 536, 279, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 101, 193, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 12, 200, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 552, 21, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 73, 230, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 468, 199, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 441, 222, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 16, 197, 65526, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 244, 184, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 289, 180, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 215, 231, 65469, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 26, 262, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 72, 288, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 443, 180, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 610, 262, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 133, 94, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(35481, 377, 84, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 109, 218, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 147, 212, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 37, 52, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 104, 66, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 384, 48, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 384, 203, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 331, 188, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 646, 70, 65496, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 591, 83, 0, 5205));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 604, 23, 0, 5205));
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

