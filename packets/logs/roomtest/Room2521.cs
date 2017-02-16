using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2521 : Room
  {
        public Room2521()
            : base(2521, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 545, 140, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 489, 134, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 460, 143, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 16, 141, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 295, 141, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 191, 142, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 610, 139, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 361, 326, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 390, 257, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 406, 256, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 222, 236, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 157, 223, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 207, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 212, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 80, 228, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 104, 227, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 139, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 27, 147, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 146, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 189, 142, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 140, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 292, 139, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 315, 139, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 452, 142, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 472, 143, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 132, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 497, 132, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 521, 139, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 546, 139, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 138, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 594, 138, 0, 2521));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 623, 138, 0, 2521));
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

