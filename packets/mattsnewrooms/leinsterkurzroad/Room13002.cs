using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13002 : Room
  {
        public Room13002()
            : base(13002, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 304, 106, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 184, 124, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 458, 219, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 74, 284, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 306, 228, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 319, 212, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(241, 327, 39, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 526, 116, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32919, 6, 163, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 563, 186, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 330, 143, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 636, 158, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 192, 263, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 2, 157, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 101, 166, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 195, 271, 27, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 318, 213, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 35, 279, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 51, 252, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 522, 184, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 546, 184, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 570, 184, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 594, 184, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 129, 162, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 117, 162, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 105, 162, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 93, 162, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 82, 162, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 70, 162, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 231, 140, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 244, 140, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 256, 140, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 268, 140, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 280, 140, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 292, 140, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 60, 157, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 51, 157, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 38, 157, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 25, 157, 0, 13002));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 13, 157, 0, 13002));
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

