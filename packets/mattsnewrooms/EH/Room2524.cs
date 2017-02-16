using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2524 : Room
  {
        public Room2524()
            : base(2524, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 284, 139, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 489, 139, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 79, 130, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 152, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 262, 139, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 343, 139, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 429, 139, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 408, 144, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 564, 141, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 144, 139, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 25, 142, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 313, 247, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 232, 259, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 432, 220, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 472, 233, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 226, 270, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(35720, 19, 213, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 182, 261, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 102, 325, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 259, 238, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 67, 219, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 331, 257, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 155, 139, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 132, 140, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 348, 139, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 395, 146, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 366, 138, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 462, 139, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 486, 139, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 138, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 549, 140, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 573, 151, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 151, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 624, 142, 0, 2524));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 601, 142, 0, 2524));
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

