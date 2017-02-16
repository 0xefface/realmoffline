using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13101 : Room
  {
        public Room13101()
            : base(13101, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 306, 105, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 184, 124, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 621, 211, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 372, 252, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 306, 228, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 621, 210, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(241, 265, 33, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 521, 120, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 295, 126, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 0, 151, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 312, 161, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 490, 156, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 570, 159, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(32920, 126, 157, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 38, 159, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 435, 163, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(32918, 65440, 158, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 416, 162, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 84, 153, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 95, 153, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 55, 158, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 25, 158, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 445, 162, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 105, 153, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 117, 153, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 129, 153, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 141, 153, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 153, 153, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 164, 153, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 533, 153, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 522, 153, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 510, 153, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 499, 153, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 487, 153, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 475, 153, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 463, 153, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 451, 152, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 547, 158, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 569, 157, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 597, 157, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 212, 156, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 224, 156, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 235, 156, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 249, 156, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 261, 156, 0, 13101));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 273, 156, 0, 13101));
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

