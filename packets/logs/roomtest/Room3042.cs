using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3042 : Room
  {
        public Room3042()
            : base(3042, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 284, 139, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 278, 118, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 417, 143, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 577, 139, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 241, 176, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 276, 145, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 97, 120, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 350, 138, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 87, 86, 65516, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 480, 139, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 183, 145, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 119, 214, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 242, 218, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 35, 254, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 372, 256, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 252, 227, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 83, 65516, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 65471, 106, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 8, 156, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(203, 239, 138, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(32816, 511, 240, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(3952, 306, 247, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 472, 241, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 373, 245, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 65, 104, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(32836, 64, 349, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(68, 502, 353, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 171, 340, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(3712, 591, 346, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 266, 359, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 14, 118, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 124, 215, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 492, 244, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 26, 255, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(1061, 605, 320, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 157, 147, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 183, 145, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 278, 176, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 242, 175, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 215, 176, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 289, 145, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 319, 136, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 429, 141, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 444, 142, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 548, 138, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 572, 138, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 601, 140, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 628, 139, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 318, 137, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 298, 135, 0, 3042));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 84, 120, 0, 3042));
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

