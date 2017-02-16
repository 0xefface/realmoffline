using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3017 : Room
  {
        public Room3017()
            : base(3017, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 447, 139, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 629, 136, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 135, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 152, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 369, 138, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 521, 134, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 34, 257, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 534, 231, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 116, 231, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 421, 235, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 475, 265, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 568, 263, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 318, 256, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 256, 257, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 528, 223, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 604, 129, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 443, 105, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 274, 116, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 567, 269, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 286, 261, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 134, 223, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 469, 272, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 9, 125, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 133, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 86, 133, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 169, 134, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 105, 134, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 356, 138, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 138, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 606, 137, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 137, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 398, 138, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 450, 137, 0, 3017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 500, 135, 0, 3017));
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

