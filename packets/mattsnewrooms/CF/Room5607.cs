using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5607 : Room
  {
        public Room5607()
            : base(5607, "Caer Fandry Gatekeeper")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2606, 161, 91, 150, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 364, 84, 60, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 466, 41, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 615, 210, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 251, 66, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 390, 134, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2720, 422, 192, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2735, 600, 182, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2732, 516, 209, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 446, 184, 131, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 526, 210, 160, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 413, 193, 160, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 558, 198, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 13, 196, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 71, 193, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 608, 23, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 714, 336, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 717, 176, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 626, 184, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 636, 306, 203, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 47, 220, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2734, 515, 198, 65525, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 604, 188, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 65532, 184, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 41, 132, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 78, 232, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 110, 56, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 300, 61, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 144, 15, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 95, 28, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 23, 88, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 313, 73, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 529, 169, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 546, 142, 0, 5607));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 457, 215, 0, 5607));
          this.AllowCasting = False;
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

