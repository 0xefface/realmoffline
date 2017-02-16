using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13009 : Room
  {
        public Room13009()
            : base(13009, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 227, 106, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 260, 109, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 45, 278, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 14, 272, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(33009, 602, 38, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 517, 123, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 24, 101, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 45, 101, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 18, 336, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 63, 101, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(1061, 50, 263, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 18, 178, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 80, 101, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 65530, 222, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 3, 101, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 469, 126, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 75, 130, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 378, 203, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 631, 135, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(32985, 94, 105, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(32974, 124, 140, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(33015, 136, 206, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(210, 432, 217, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(32979, 559, 214, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(32980, 300, 215, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 123, 195, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 96, 200, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 134, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 134, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 47, 175, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 31, 176, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 633, 209, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 645, 192, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 641, 252, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 644, 269, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 644, 289, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 111, 106, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 133, 109, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 156, 108, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 171, 110, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 92, 112, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 75, 115, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 57, 114, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 39, 118, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 22, 116, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(7908, 105, 122, 0, 13009));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 621, 245, 0, 13009));
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

