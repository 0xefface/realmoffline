using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13103 : Room
  {
        public Room13103()
            : base(13103, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 105, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(35720, 202, 211, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 291, 141, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 28, 318, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(33014, 12, 20, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 615, 149, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 145, 104, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 161, 111, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(33013, 58, 28, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 226, 138, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 442, 131, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 523, 140, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 218, 240, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 596, 172, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(186, 168, 216, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(32919, 65527, 187, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 394, 125, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 145, 149, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 81, 224, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 137, 219, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 340, 126, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 352, 126, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 365, 126, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 377, 126, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 390, 126, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 401, 126, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 413, 126, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 424, 126, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 260, 134, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 271, 134, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 248, 134, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 236, 134, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 226, 134, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 174, 145, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 162, 145, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 151, 145, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 139, 145, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 127, 145, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 115, 145, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 103, 145, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 282, 139, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 294, 139, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 305, 139, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 316, 139, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 634, 147, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 622, 147, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 610, 147, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 600, 147, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 588, 147, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 581, 150, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 532, 136, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 520, 136, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 508, 136, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 496, 136, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 484, 136, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 544, 136, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 556, 136, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 473, 136, 0, 13103));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 566, 136, 0, 13103));
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

