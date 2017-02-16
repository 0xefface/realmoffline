using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5054 : Room
  {
        public Room5054()
            : base(5054, "Leinster")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 595, 71, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(2627, 547, 62, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 651, 65, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 195, 49, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 516, 4, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 104, 5, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 578, 227, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 65529, 32, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 66, 46, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 60, 78, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 75, 103, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 65523, 115, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 151, 61, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 178, 14, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 551, 47, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 533, 45, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 571, 244, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(121, 546, 235, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 526, 228, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 556, 236, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(14, 641, 262, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 85, 281, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 37, 100, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(32813, 105, 73, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 60, 101, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 113, 74, 0, 5054));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 24, 350, 0, 5054));
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

