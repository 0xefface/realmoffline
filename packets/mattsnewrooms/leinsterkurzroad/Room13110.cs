using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13110 : Room
  {
        public Room13110()
            : base(13110, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 531, 121, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 330, 107, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 461, 152, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 475, 153, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 618, 169, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 54, 324, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(33014, 339, 65, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 631, 109, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 145, 104, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 207, 122, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(245, 396, 76, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 87, 226, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 541, 241, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 225, 225, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 406, 281, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 286, 322, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 624, 379, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 460, 153, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 346, 110, 6, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 6, 109, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 331, 236, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 442, 158, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 470, 158, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 593, 167, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 605, 167, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 617, 167, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 628, 167, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 639, 167, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 108, 124, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 127, 124, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 151, 123, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 175, 123, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 199, 123, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 222, 122, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 245, 123, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 269, 123, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 293, 124, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 317, 124, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 418, 123, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 442, 123, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 484, 122, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 123, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 122, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 556, 122, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 122, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 625, 123, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 175, 265, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 340, 188, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 358, 146, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 364, 182, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 362, 119, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(33002, 357, 109, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 370, 144, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 281, 229, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 221, 271, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 140, 224, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 205, 245, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 170, 223, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 246, 227, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 406, 236, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 457, 241, 0, 13110));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 64, 231, 0, 13110));
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

