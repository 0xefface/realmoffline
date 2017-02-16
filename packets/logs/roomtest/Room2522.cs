using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2522 : Room
  {
        public Room2522()
            : base(2522, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 353, 132, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 507, 138, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 24, 256, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 354, 248, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 10, 269, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 185, 237, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 210, 220, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 179, 232, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 464, 239, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 45, 265, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 589, 254, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 584, 268, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 52, 131, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 131, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 87, 130, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 117, 139, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 139, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 296, 139, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 319, 139, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 382, 145, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 401, 145, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 431, 137, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 452, 137, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 484, 138, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 137, 0, 2522));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 523, 137, 0, 2522));
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

