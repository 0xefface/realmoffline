using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4030 : Room
  {
        public Room4030()
            : base(4030, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 515, 108, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 119, 116, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 231, 324, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 142, 188, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 125, 191, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 160, 190, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(32943, 359, 103, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 531, 113, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 110, 122, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 593, 124, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 209, 113, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 18, 174, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(220, 65, 255, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(221, 34, 126, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(239, 51, 201, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 65527, 201, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(33005, 40, 154, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(33004, 54, 118, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 606, 124, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 629, 124, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 124, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(182, 84, 253, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 560, 124, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 60, 193, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 39, 193, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 18, 192, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 49, 151, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 30, 151, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 23, 133, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 63, 112, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 65517, 282, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 65511, 273, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 5, 128, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 53, 175, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 49, 165, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 38, 170, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(181, 42, 254, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 72, 201, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 88, 121, 0, 4030));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 111, 121, 0, 4030));
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

