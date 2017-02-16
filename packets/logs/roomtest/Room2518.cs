using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2518 : Room
  {
        public Room2518()
            : base(2518, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 353, 123, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 545, 130, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 139, 134, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 500, 136, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 597, 136, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 168, 138, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 271, 145, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 113, 146, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 35, 144, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 81, 135, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 410, 143, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 332, 141, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 26, 129, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 446, 212, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 378, 254, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 545, 329, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 448, 213, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 385, 255, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 12, 143, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 36, 143, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 56, 143, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 107, 145, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 123, 145, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 140, 136, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 159, 137, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 181, 137, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 194, 137, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 264, 144, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 285, 144, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 317, 140, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 341, 140, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 400, 142, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 485, 135, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 508, 135, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 531, 136, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 569, 135, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 588, 135, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 611, 135, 0, 2518));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 624, 134, 0, 2518));
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

