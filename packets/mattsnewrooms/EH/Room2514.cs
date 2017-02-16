using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2514 : Room
  {
        public Room2514()
            : base(2514, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 205, 141, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 109, 136, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 64, 132, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 20, 132, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 39, 207, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 328, 273, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 329, 274, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 385, 225, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 353, 246, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 143, 238, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 370, 224, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 434, 237, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 565, 260, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 106, 232, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 120, 203, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 345, 173, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 264, 186, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 465, 172, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 590, 171, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 218, 205, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 42, 234, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 177, 294, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 150, 311, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 49, 221, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 139, 293, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 574, 261, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 578, 330, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 314, 263, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 15, 214, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 410, 216, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 143, 239, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 159, 253, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 68, 327, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 227, 221, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 106, 135, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 77, 130, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 181, 140, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 206, 139, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 230, 140, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 253, 135, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 303, 140, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 395, 145, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 430, 137, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 453, 138, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 476, 138, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 508, 145, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 532, 145, 0, 2514));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 624, 143, 0, 2514));
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

