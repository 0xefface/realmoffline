using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3045 : Room
  {
        public Room3045()
            : base(3045, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 508, 138, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 137, 140, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 574, 143, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 544, 152, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 21, 155, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 384, 151, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 609, 158, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 448, 223, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 376, 248, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 256, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 449, 232, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 380, 253, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 223, 238, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 413, 217, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 50, 147, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 17, 207, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 312, 250, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 148, 235, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 436, 342, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(68, 310, 351, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 590, 270, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 57, 339, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 311, 253, 13, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 605, 257, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 9, 208, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 37, 153, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 51, 146, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 75, 146, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 92, 130, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 109, 138, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 128, 138, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 137, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 272, 137, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 297, 137, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 330, 138, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 350, 139, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 478, 137, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 501, 137, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 525, 137, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 149, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 550, 149, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 150, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 589, 156, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 155, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 568, 142, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 142, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 617, 143, 0, 3045));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 142, 0, 3045));
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

