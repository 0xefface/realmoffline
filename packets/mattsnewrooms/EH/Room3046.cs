using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3046 : Room
  {
        public Room3046()
            : base(3046, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 77, 124, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 573, 134, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 260, 142, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 145, 142, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 152, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 200, 156, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 253, 161, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 384, 151, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 525, 150, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 312, 248, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 144, 222, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(3952, 501, 231, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 446, 245, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 239, 269, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 60, 203, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 30, 209, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 228, 261, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 439, 244, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 605, 210, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 55, 213, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 524, 233, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(68, 27, 333, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 123, 328, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 607, 211, 28, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 312, 256, 29, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 144, 222, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 126, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 90, 131, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 111, 141, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 134, 145, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 359, 150, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 383, 150, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 404, 150, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 417, 138, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 359, 138, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 138, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 483, 138, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 502, 149, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 149, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 548, 149, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 149, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 149, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 143, 0, 3046));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 263, 168, 0, 3046));
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

