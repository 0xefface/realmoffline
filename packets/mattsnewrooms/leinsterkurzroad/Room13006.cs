using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13006 : Room
  {
        public Room13006()
            : base(13006, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(35510, 108, 109, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 310, 105, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 529, 179, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 520, 180, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 618, 169, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 632, 323, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(33014, 12, 20, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 631, 109, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 145, 104, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 161, 111, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(33013, 58, 28, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 274, 128, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 47, 151, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 65508, 133, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 301, 127, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 292, 297, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 50, 336, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 36, 317, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 42, 317, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 9, 130, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 10, 162, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 21, 167, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(219, 80, 167, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(218, 96, 203, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(221, 130, 238, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32989, 91, 270, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 187, 279, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 187, 186, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 42, 184, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 122, 193, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 124, 201, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 77, 192, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 21, 173, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 6, 170, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 50, 156, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 40, 157, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 62, 147, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 80, 147, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 125, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 295, 126, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 318, 126, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 144, 315, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 162, 321, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 179, 322, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 194, 323, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 33, 320, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 9, 319, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 19, 321, 0, 13006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 100, 329, 0, 13006));
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

