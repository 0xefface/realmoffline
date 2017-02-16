using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13005 : Room
  {
        public Room13005()
            : base(13005, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(35510, 108, 109, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 310, 104, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 123, 219, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 167, 226, 27, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 618, 169, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 54, 324, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(33014, 12, 20, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 631, 109, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 145, 104, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 161, 111, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(33013, 58, 28, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 634, 335, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 373, 155, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 314, 198, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 545, 256, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 329, 152, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 339, 152, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 351, 152, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 363, 152, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 375, 152, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 387, 152, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 399, 152, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 411, 152, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 636, 167, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 624, 167, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 612, 167, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 601, 167, 0, 13005));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 415, 152, 0, 13005));
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

