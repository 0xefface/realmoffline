using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13104 : Room
  {
        public Room13104()
            : base(13104, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 297, 112, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 469, 104, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 104, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 472, 128, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 666, 131, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 29, 319, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 208, 243, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 597, 324, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(33012, 25, 67, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 601, 130, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 614, 160, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 576, 164, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 178, 123, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 63, 163, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 172, 191, 40, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 264, 134, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(182, 555, 183, 20, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 156, 157, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 521, 164, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 401, 216, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 404, 221, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 87, 149, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 98, 149, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 110, 149, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 122, 149, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 134, 149, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 147, 149, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 159, 149, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 171, 149, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 183, 149, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 62, 159, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 51, 159, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 74, 159, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 86, 159, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 98, 159, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 634, 156, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 622, 156, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 610, 156, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 519, 160, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 507, 160, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 495, 160, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 483, 160, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 471, 160, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 531, 160, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 544, 160, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 555, 160, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 567, 160, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 579, 160, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 591, 154, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 335, 114, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 340, 113, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 331, 138, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 339, 137, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 337, 162, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 318, 211, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 302, 239, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 329, 239, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 339, 186, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 343, 162, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 221, 251, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(32991, 367, 242, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 375, 215, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(32991, 205, 237, 0, 13104));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 171, 247, 0, 13104));
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

