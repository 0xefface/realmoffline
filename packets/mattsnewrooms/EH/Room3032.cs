using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3032 : Room
  {
        public Room3032()
            : base(3032, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 67, 126, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 247, 132, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 461, 135, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 120, 140, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 505, 146, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 368, 121, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 288, 133, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 34, 137, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 343, 140, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 558, 140, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 79, 129, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 162, 243, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 485, 240, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 410, 105, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 289, 107, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 566, 122, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(121, 663, 330, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 469, 239, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 38, 238, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 310, 248, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 222, 223, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 232, 224, 9, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 522, 256, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 217, 252, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 121, 257, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 389, 252, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 517, 249, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 98, 250, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 0, 307, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 235, 313, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 314, 309, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 341, 306, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 541, 246, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 300, 248, 65535, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 197, 227, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 488, 302, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 41, 247, 20, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 228, 229, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 415, 129, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 397, 173, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 392, 233, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 138, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 89, 139, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 112, 139, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 135, 139, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 139, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 176, 130, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 535, 140, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 557, 140, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 140, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 604, 144, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 144, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 363, 140, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 338, 140, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 257, 133, 0, 3032));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 517, 144, 0, 3032));
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

