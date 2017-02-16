using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13108 : Room
  {
        public Room13108()
            : base(13108, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 306, 105, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 653, 122, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 407, 228, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 372, 252, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 306, 228, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 365, 236, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(33009, 413, 59, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 526, 116, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 260, 358, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 95, 228, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 291, 241, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 531, 237, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 137, 135, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 366, 242, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 118, 133, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 108, 133, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 97, 133, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 85, 133, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 73, 133, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 61, 133, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 52, 134, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 44, 133, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 35, 133, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 208, 122, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 543, 125, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 125, 0, 13108));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 578, 125, 0, 13108));
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

