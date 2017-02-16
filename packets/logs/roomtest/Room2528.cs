using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2528 : Room
  {
        public Room2528()
            : base(2528, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 339, 137, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 507, 139, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 592, 137, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 334, 138, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 261, 139, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 423, 138, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 474, 133, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 361, 326, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 390, 256, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(35720, 401, 255, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 221, 234, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 157, 223, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 207, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 18, 208, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 80, 233, 8, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 104, 233, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 264, 139, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 282, 138, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 328, 136, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 346, 136, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 425, 137, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 444, 137, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 461, 133, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 484, 133, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 483, 139, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 506, 138, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 529, 138, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 137, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 136, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 618, 137, 0, 2528));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 547, 131, 0, 2528));
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

