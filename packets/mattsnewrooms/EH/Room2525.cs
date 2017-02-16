using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2525 : Room
  {
        public Room2525()
            : base(2525, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 292, 136, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 486, 138, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 87, 132, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 550, 143, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 369, 139, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 436, 145, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 252, 141, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 314, 140, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 202, 131, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 580, 262, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 211, 218, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 263, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 153, 242, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 146, 241, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 481, 237, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 327, 248, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 530, 204, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 37, 256, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 89, 131, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 112, 131, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 239, 140, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 261, 140, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 299, 139, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 368, 139, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 378, 138, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 411, 144, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 433, 144, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 464, 135, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 455, 144, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 548, 142, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 519, 138, 0, 2525));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 621, 142, 0, 2525));
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

