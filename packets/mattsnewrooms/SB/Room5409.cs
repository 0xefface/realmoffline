using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5409 : Room
  {
        public Room5409()
            : base(5409, "Silverbrook Auction Hall")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2953, 177, 18, 65437, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 279, 177, 0, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 202, 142, 7, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 494, 149, 7, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 490, 17, 65521, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 594, 27, 0, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 527, 44, 0, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 200, 47, 0, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 494, 127, 70, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 389, 23, 0, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 285, 18, 0, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 239, 23, 0, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 264, 41, 0, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 441, 49, 0, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 179, 19, 0, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 52, 5, 0, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 493, 148, 0, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 289, 139, 0, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 201, 141, 0, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 289, 140, 7, 5409));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 490, 201, 0, 5409));
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

