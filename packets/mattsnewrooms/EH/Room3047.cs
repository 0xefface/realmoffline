using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3047 : Room
  {
        public Room3047()
            : base(3047, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 71, 125, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 423, 127, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 595, 136, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 130, 131, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 502, 137, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 200, 156, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 292, 122, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 26, 139, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 525, 150, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 78, 133, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 376, 248, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 594, 270, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 452, 231, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 393, 253, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 95, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 533, 215, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 42, 212, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 433, 223, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 309, 247, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 288, 112, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 426, 118, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 526, 113, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 217, 222, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 177, 243, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 56, 213, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 332, 262, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 534, 273, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 504, 263, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 591, 257, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 623, 274, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 368, 350, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 533, 344, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 79, 133, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 103, 132, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 127, 131, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 151, 131, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 259, 122, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 282, 122, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 306, 123, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 331, 122, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 398, 127, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 422, 127, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 126, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 503, 150, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 150, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 137, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 517, 137, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 540, 138, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 563, 138, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 587, 138, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 610, 137, 0, 3047));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 137, 0, 3047));
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

