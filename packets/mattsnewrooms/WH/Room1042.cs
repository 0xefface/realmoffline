using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1042 : Room
  {
        public Room1042()
            : base(1042, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32868, 55, 318, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 20, 284, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 0, 232, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 65517, 234, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 24, 164, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 12, 180, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 2, 146, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(32868, 0, 144, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(32834, 108, 154, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 163, 107, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 2, 108, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(32978, 194, 257, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(210, 348, 254, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 542, 252, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(245, 443, 75, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 252, 103, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 592, 104, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 209, 80, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 138, 116, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 57, 155, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(142, 162, 80, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 227, 225, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 424, 227, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 392, 174, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 247, 172, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 394, 168, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(32881, 221, 216, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 299, 318, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 18, 252, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(32828, 33, 181, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 399, 225, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 445, 241, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 424, 250, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 416, 239, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 443, 299, 0, 1042));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 414, 300, 0, 1042));
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

