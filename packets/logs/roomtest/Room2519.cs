using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2519 : Room
  {
        public Room2519()
            : base(2519, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 318, 140, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 32, 204, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 354, 248, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 259, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 133, 247, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 204, 241, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 143, 238, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 431, 219, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 123, 240, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 585, 255, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 115, 138, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 89, 129, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 66, 129, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 175, 138, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 198, 139, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 248, 137, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 291, 139, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 314, 139, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 380, 146, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 401, 146, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 462, 138, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 478, 138, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 508, 144, 0, 2519));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 530, 144, 0, 2519));
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

