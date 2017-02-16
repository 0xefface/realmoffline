using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13100 : Room
  {
        public Room13100()
            : base(13100, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 308, 104, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 377, 145, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 376, 149, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 618, 169, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 60, 327, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(33014, 12, 31, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 631, 109, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 145, 104, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 161, 111, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(33013, 58, 53, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 326, 131, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 494, 126, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 572, 146, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 11, 208, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 138, 143, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(32925, 459, 201, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 80, 139, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 394, 220, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 69, 136, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 209, 148, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 443, 146, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 301, 141, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 205, 268, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 38, 298, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 384, 220, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 242, 267, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 478, 202, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 600, 167, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 620, 167, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 629, 166, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 413, 192, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 431, 192, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 449, 192, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 466, 192, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 483, 192, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 497, 192, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 251, 146, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 239, 146, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 227, 146, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 340, 139, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 283, 139, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 292, 141, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 259, 139, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 317, 139, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 216, 146, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 205, 146, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 193, 146, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 181, 146, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 170, 146, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 159, 146, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 411, 144, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 423, 144, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 435, 144, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 447, 144, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 459, 144, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 181, 139, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 170, 139, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 159, 139, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 150, 139, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 139, 139, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 127, 139, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 115, 139, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 103, 139, 0, 13100));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 92, 139, 0, 13100));
          this.AllowCasting = False;
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

