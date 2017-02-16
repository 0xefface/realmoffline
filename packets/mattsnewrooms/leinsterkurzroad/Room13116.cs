using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13116 : Room
  {
        public Room13116()
            : base(13116, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 243, 114, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 515, 118, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(32943, 309, 105, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 433, 220, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 441, 187, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 51, 154, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 262, 323, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(33014, 9, 43, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 104, 155, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 145, 104, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 293, 125, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(33013, 59, 50, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 620, 100, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 9, 108, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 27, 151, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 39, 151, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 51, 151, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 63, 151, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 74, 151, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 86, 151, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 97, 151, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 109, 151, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 121, 151, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 133, 151, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 175, 123, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 195, 126, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 219, 126, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 291, 126, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 315, 126, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 339, 124, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 382, 127, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 405, 126, 0, 13116));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 362, 127, 0, 13116));
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

