using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5081 : Room
  {
        public Room5081()
            : base(5081, "Leinster")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 408, 450, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(35303, 251, 450, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 201, 450, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(35303, 459, 450, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(35303, 173, 460, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(35303, 538, 459, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 487, 459, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 122, 460, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 566, 459, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(35303, 93, 460, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 43, 460, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(35303, 14, 459, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(35303, 616, 459, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 643, 458, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 95, 329, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 567, 328, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 217, 313, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 572, 10, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 538, 12, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 568, 46, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 80, 49, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 477, 7, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 65519, 70, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 84, 9, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 63, 15, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 571, 49, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 69, 52, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 624, 85, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(35515, 130, 48, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 567, 88, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 512, 82, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(2749, 404, 48, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 465, 62, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 102, 73, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 58, 90, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 12, 104, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 40, 108, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 100, 99, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 156, 72, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 117, 97, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 418, 61, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 475, 85, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 559, 97, 0, 5081));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 602, 102, 0, 5081));
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

