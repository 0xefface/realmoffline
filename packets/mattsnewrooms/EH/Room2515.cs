using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2515 : Room
  {
        public Room2515()
            : base(2515, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 569, 126, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 304, 137, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 533, 138, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 145, 137, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 495, 129, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 186, 144, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 343, 139, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 418, 143, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 263, 141, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 571, 144, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 343, 255, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 212, 215, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 598, 208, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 197, 263, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 284, 265, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(35720, 25, 253, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 156, 211, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 110, 321, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 250, 212, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 368, 217, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 52, 318, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 471, 105, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 451, 150, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 441, 150, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 463, 150, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 22, 262, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 166, 218, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 224, 225, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 265, 224, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 604, 216, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 343, 269, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 525, 212, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 401, 270, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 125, 163, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 457, 160, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 361, 163, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 242, 163, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 26, 163, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 61, 132, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 11, 126, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 82, 131, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 276, 140, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 316, 137, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 371, 137, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 403, 141, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 427, 141, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 435, 142, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 505, 136, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 493, 125, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 529, 136, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 555, 143, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 576, 143, 0, 2515));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 622, 143, 0, 2515));
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

