using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2001 : Room
  {
        public Room2001()
            : base(2001, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 183, 129, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 365, 118, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 571, 139, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 59, 281, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 39, 289, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 478, 272, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 488, 276, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 55, 120, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 46, 289, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 160, 126, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 182, 128, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 204, 127, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 138, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 548, 137, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 568, 136, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 248, 115, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 345, 118, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 368, 119, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 390, 118, 0, 2001));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 629, 120, 0, 2001));
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

