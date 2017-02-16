using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5909 : Room
  {
        public Room5909()
            : base(5909, "Institute of Warfare")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 135, 29, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 416, 130, 65516, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 277, 16, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 381, 37, 50, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 102, 135, 65516, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 610, 120, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(35381, 563, 127, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2710, 362, 47, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 200, 134, 65516, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(35382, 624, 69, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 114, 181, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 129, 194, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 487, 202, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 167, 198, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 400, 187, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 589, 208, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2701, 374, 156, 64, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(35483, 136, 143, 65506, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 152, 178, 20, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 496, 149, 65506, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 555, 173, 20, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 630, 195, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 561, 200, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2621, 699, 121, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 52, 66, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 92, 178, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 215, 187, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 352, 168, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2613, 187, 79, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 228, 52, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(34354, 63, 284, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(34354, 9, 2, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(34354, 65517, 56, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(34354, 32, 271, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(34354, 65532, 256, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(1587, 102, 252, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(1531, 35, 315, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(1536, 62, 65, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(1587, 21, 84, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(1586, 12, 234, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(34354, 16, 209, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(1520, 66, 320, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(34355, 61, 161, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(34355, 133, 174, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(34354, 336, 173, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(34354, 174, 283, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(1588, 200, 191, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(1588, 329, 175, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(34356, 251, 185, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 507, 224, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2596, 430, 139, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 212, 146, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2596, 117, 143, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 226, 220, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 121, 224, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 513, 202, 0, 5909));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 537, 202, 0, 5909));
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

