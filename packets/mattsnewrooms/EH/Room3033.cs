using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3033 : Room
  {
        public Room3033()
            : base(3033, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 568, 133, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 428, 140, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 595, 141, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 142, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 268, 148, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 462, 151, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 523, 141, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 208, 307, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 324, 257, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(121, 23, 345, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 335, 246, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 608, 218, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 218, 233, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 287, 245, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 374, 153, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32997, 581, 254, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 348, 252, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 116, 249, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 613, 219, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 103, 141, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 125, 141, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 141, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 172, 141, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 317, 139, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 369, 152, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 392, 152, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 442, 150, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 465, 150, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 487, 150, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 500, 140, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 523, 140, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 546, 140, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 140, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 587, 140, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 140, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 73, 132, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 50, 132, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 97, 132, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 253, 145, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 410, 138, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 428, 138, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 138, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 367, 140, 0, 3033));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 461, 138, 0, 3033));
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

