using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13107 : Room
  {
        public Room13107()
            : base(13107, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 162, 108, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 80, 112, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(32943, 309, 104, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 511, 219, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 404, 174, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 626, 124, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 54, 324, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(33014, 12, 20, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 20, 118, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 439, 108, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 536, 110, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(33013, 58, 40, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 167, 166, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 300, 168, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 592, 231, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 464, 203, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 370, 169, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 387, 174, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 405, 169, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 487, 207, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 384, 254, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 129, 153, 65521, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(1110, 288, 150, 65516, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(1110, 304, 146, 65516, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 40, 167, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 398, 182, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 391, 192, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 528, 226, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 13, 118, 0, 13107));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 624, 125, 0, 13107));
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

