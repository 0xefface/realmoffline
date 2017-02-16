using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3043 : Room
  {
        public Room3043()
            : base(3043, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 77, 124, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 290, 142, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 480, 137, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 632, 143, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 54, 132, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 586, 150, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 550, 159, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 341, 139, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 506, 149, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 417, 138, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 534, 142, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 132, 132, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 332, 246, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 18, 208, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 612, 256, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 460, 235, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 144, 244, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(3952, 218, 237, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 434, 223, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 155, 236, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 2, 267, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 385, 247, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 485, 234, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 104, 333, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 612, 261, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 56, 131, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 80, 131, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 114, 131, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 133, 131, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 217, 128, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 299, 132, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 372, 140, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 394, 140, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 157, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 561, 157, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 512, 147, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 147, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 148, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 141, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 599, 148, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 610, 143, 0, 3043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 417, 139, 0, 3043));
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

