using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13003 : Room
  {
        public Room13003()
            : base(13003, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 220, 107, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 174, 124, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 407, 228, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 372, 252, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 269, 125, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 3, 321, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(241, 463, 1, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 523, 116, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 472, 103, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 8, 159, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 7, 204, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 13, 393, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32919, 65512, 156, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 52, 139, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 70, 131, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 113, 132, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 380, 173, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 326, 147, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 336, 109, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 509, 192, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 557, 194, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 386, 169, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 338, 148, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 329, 120, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 351, 222, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 259, 226, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(32991, 524, 234, 0, 13003));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 614, 194, 0, 13003));
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

