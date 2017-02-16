using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5084 : Room
  {
        public Room5084()
            : base(5084, "Hunter's Retreat")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 408, 450, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(35303, 251, 450, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 201, 450, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(35303, 459, 450, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(35303, 173, 460, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(35303, 538, 459, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 487, 459, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 122, 460, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 566, 459, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(35303, 93, 460, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 43, 460, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(35303, 14, 459, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(35303, 616, 459, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 643, 458, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 95, 329, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 567, 328, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 217, 313, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 106, 259, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 523, 262, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 84, 232, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 593, 237, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 311, 108, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 372, 122, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 354, 169, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 261, 168, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 245, 121, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 235, 146, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 378, 148, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 111, 7, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 523, 7, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 53, 38, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 563, 30, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 47, 57, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 585, 71, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 65, 21, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 570, 56, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 65535, 209, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 606, 210, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 587, 244, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 57, 237, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 655, 85, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 65514, 84, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 17, 94, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 596, 110, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 494, 79, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(121, 590, 87, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 45, 70, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 82, 60, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 106, 84, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 130, 60, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 559, 106, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 583, 106, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(1587, 317, 137, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(1588, 309, 140, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 563, 288, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 627, 289, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 69, 313, 0, 5084));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 19, 290, 0, 5084));
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

