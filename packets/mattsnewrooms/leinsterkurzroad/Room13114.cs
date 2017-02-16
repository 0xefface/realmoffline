using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13114 : Room
  {
        public Room13114()
            : base(13114, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32943, 336, 104, 0, 13114));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 48, 115, 0, 13114));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 407, 228, 0, 13114));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 372, 252, 0, 13114));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 306, 228, 0, 13114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 623, 256, 0, 13114));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 526, 116, 0, 13114));
          this.AddRoomDecoration(RoomDecoration.FromCode(245, 135, 60, 0, 13114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 146, 112, 0, 13114));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 382, 106, 0, 13114));
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

