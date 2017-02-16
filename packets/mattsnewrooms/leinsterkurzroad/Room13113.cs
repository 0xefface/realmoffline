using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13113 : Room
  {
        public Room13113()
            : base(13113, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 512, 113, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 105, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 48, 331, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 401, 330, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 632, 158, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 441, 243, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(33014, 284, 46, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 580, 160, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 145, 106, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 161, 111, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(33013, 570, 38, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 477, 253, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 431, 252, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 546, 156, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 563, 156, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 581, 156, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 598, 156, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 615, 156, 0, 13113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 631, 156, 0, 13113));
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

