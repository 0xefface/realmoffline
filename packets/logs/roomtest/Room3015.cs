using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3015 : Room
  {
        public Room3015()
            : base(3015, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 453, 139, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 143, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 553, 140, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 327, 140, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 361, 326, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 394, 269, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 406, 259, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 220, 225, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 143, 221, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 207, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 23, 208, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 80, 228, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 104, 227, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 142, 227, 21, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 219, 226, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 289, 139, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 313, 139, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 337, 139, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 360, 139, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 365, 144, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 144, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 426, 138, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 449, 138, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 472, 138, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 496, 138, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 517, 134, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 547, 139, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 537, 133, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 139, 0, 3015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 141, 0, 3015));
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

