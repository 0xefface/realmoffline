using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8012 : Room
  {
        public Room8012()
            : base(8012, "Magic Mystery Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 128, 4, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 35, 33, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 326, 55, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 405, 12, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2018, 595, 27, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 506, 2, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 235, 12, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2047, 537, 159, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2048, 40, 159, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 351, 168, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2556, 553, 131, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2557, 94, 131, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2558, 391, 141, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 481, 312, 60, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2147, 545, 314, 50, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2131, 494, 314, 50, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 540, 310, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(34899, 501, 313, 60, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2131, 443, 296, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(34899, 560, 316, 60, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2131, 611, 315, 50, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(34921, 519, 310, 50, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 525, 312, 60, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(34921, 443, 305, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 586, 312, 50, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2106, 464, 214, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2147, 473, 311, 50, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(34915, 551, 314, 60, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(34915, 596, 311, 60, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2134, 478, 219, 70, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2133, 450, 217, 70, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2132, 613, 210, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(34918, 38, 212, 0, 8012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2151, 28, 315, 0, 8012));
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

