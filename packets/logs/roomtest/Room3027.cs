using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3027 : Room
  {
        public Room3027()
            : base(3027, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 92, 125, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 284, 139, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 489, 139, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 145, 137, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 152, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 186, 144, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 343, 139, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 429, 139, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 147, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 547, 142, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 56, 138, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 313, 248, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 212, 268, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 606, 200, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 472, 233, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 226, 269, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(3952, 19, 213, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 182, 261, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 99, 320, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(32818, 282, 247, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 67, 219, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 330, 261, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 606, 215, 32, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 608, 229, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 568, 150, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 407, 145, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 383, 145, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 363, 145, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 379, 138, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 355, 138, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 141, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 550, 141, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 526, 141, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 515, 138, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 138, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 468, 138, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 444, 138, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 420, 138, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 58, 124, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 124, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 13, 124, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 160, 137, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 138, 137, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 138, 0, 3027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 33, 138, 0, 3027));
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

