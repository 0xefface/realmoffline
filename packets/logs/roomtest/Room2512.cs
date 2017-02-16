using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2512 : Room
  {
        public Room2512()
            : base(2512, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 363, 139, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 551, 141, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 486, 138, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 184, 140, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 439, 143, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 621, 142, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 414, 344, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 390, 252, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 406, 251, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 220, 238, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 157, 223, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 207, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 19, 208, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 80, 228, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 104, 227, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 189, 141, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 337, 139, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 360, 138, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 383, 138, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 428, 142, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 452, 142, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 483, 136, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 497, 136, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 528, 140, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 551, 140, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 575, 140, 0, 2512));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 627, 141, 0, 2512));
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

