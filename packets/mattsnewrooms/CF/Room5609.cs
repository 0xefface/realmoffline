using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5609 : Room
  {
        public Room5609()
            : base(5609, "Caer Fandry")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Right;
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 176, 217, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(32983, 226, 242, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(213, 341, 241, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(210, 544, 238, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(211, 683, 242, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(209, 421, 231, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 323, 291, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 327, 266, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 495, 287, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 491, 263, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 348, 291, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 355, 266, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 586, 291, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 586, 266, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 124, 259, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 152, 253, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(32957, 137, 217, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(32957, 75, 169, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(94, 334, 105, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 205, 113, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 65429, 120, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 305, 108, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(197, 65473, 110, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 65524, 130, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 110, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 589, 148, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 1, 130, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 551, 137, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 285, 294, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 19, 217, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 624, 165, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 428, 119, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 64, 147, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 82, 147, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 26, 207, 0, 5609));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 617, 151, 0, 5609));
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

