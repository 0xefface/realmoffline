using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3018 : Room
  {
        public Room3018()
            : base(3018, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.Left;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 161, 129, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 444, 133, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 182, 138, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 461, 150, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 67, 141, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 293, 140, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 587, 142, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 371, 138, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 518, 139, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 621, 264, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 309, 258, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 430, 224, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 578, 255, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 596, 268, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 60, 318, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 210, 223, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 432, 217, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(196, 17, 143, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(190, 17, 145, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(32829, 4, 185, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(61, 47, 151, 26, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 37, 109, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 33, 127, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 14, 147, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65532, 168, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 28, 141, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 9, 164, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 84, 141, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 66, 143, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 149, 138, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 174, 139, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 231, 139, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 259, 140, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 283, 140, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 347, 138, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 372, 138, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 393, 139, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 447, 152, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 476, 151, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 497, 139, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 520, 139, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 540, 137, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 575, 142, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 597, 145, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 188, 136, 0, 3018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 65532, 318, 0, 3018));
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

