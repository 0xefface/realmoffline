using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7014 : Room
  {
        public Room7014()
            : base(7014, "Traveler's Union")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 514, 189, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 595, 196, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 626, 10, 65474, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 607, 110, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2505, 168, 8, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2528, 475, 11, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2528, 260, 1, 65526, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2529, 359, 12, 65496, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 361, 62, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 286, 175, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 362, 174, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 439, 174, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 378, 146, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 302, 147, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 455, 146, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 210, 174, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 247, 47, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 405, 47, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 226, 146, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 263, 19, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 421, 19, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2701, 127, 53, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 517, 207, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 534, 211, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(35719, 571, 177, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 253, 194, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 477, 191, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 417, 192, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 212, 195, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 614, 117, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 558, 213, 0, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 112, 6, 65500, 7014));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 25, 2, 0, 7014));
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

