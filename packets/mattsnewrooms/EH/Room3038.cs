using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3038 : Room
  {
        public Room3038()
            : base(3038, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 77, 124, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 573, 137, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 132, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 149, 133, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 181, 132, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 364, 142, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 300, 145, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 40, 209, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 438, 221, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 594, 265, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 387, 261, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 78, 205, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 9, 319, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 397, 256, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32972, 621, 323, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 585, 255, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 115, 132, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 138, 132, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 161, 132, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 185, 132, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 247, 131, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 276, 144, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 299, 144, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 323, 143, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 345, 141, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 368, 141, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 463, 137, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 481, 135, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 501, 144, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 520, 143, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 144, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 442, 139, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 270, 131, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 229, 131, 0, 3038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 92, 132, 0, 3038));
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

