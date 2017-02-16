using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3035 : Room
  {
        public Room3035()
            : base(3035, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 470, 138, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 634, 135, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 190, 139, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 543, 152, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 485, 150, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 399, 137, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 566, 140, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 68, 202, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 4, 211, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 39, 221, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 79, 211, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 311, 249, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 483, 218, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 463, 114, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 292, 115, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 519, 124, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 412, 136, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 533, 265, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 392, 213, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 222, 236, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 273, 255, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 120, 144, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 157, 135, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 347, 151, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 0, 133, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 131, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 507, 266, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 471, 295, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 392, 223, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 621, 270, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 544, 254, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 232, 315, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 639, 307, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 99, 203, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 122, 149, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 529, 272, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 210, 269, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 293, 256, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 379, 214, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 485, 219, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 111, 144, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 133, 144, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 156, 144, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 169, 139, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 192, 139, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 246, 137, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 430, 137, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 137, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 139, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 139, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 135, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 135, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 152, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 135, 0, 3035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 227, 139, 0, 3035));
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

