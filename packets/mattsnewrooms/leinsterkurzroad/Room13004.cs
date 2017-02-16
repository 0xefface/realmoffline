using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13004 : Room
  {
        public Room13004()
            : base(13004, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 105, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 104, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 105, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 424, 138, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 666, 131, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 29, 319, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 408, 220, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(33012, 25, 67, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 452, 222, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 295, 136, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 307, 136, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 319, 136, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 331, 136, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 343, 136, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 355, 136, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 367, 136, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 379, 136, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 522, 135, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 431, 135, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 443, 135, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 454, 135, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 466, 135, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 478, 135, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 490, 135, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 500, 135, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 511, 135, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 534, 135, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 546, 135, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 531, 130, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 542, 127, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 556, 128, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 568, 128, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 580, 128, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 596, 128, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 607, 128, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 192, 258, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 266, 180, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 154, 165, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 145, 173, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 380, 233, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 353, 234, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 66, 164, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 325, 219, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 316, 206, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 338, 208, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 354, 219, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 356, 212, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 372, 219, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 300, 240, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 389, 213, 0, 13004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32991, 424, 312, 0, 13004));
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

