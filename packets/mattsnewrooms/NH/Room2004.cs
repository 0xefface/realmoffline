using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2004 : Room
  {
        public Room2004()
            : base(2004, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 319, 134, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 99, 128, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32918, 501, 121, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 390, 261, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 431, 283, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 383, 260, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 397, 270, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 412, 284, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 622, 136, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 295, 132, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 319, 133, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 342, 132, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 576, 134, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 600, 134, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 623, 135, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 74, 127, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 98, 127, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 121, 128, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 543, 124, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 124, 0, 2004));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 446, 276, 0, 2004));
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

