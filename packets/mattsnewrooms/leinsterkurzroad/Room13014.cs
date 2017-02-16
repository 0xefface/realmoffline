using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13014 : Room
  {
        public Room13014()
            : base(13014, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(35510, 108, 109, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 104, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(33014, 12, 20, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 631, 109, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 145, 104, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 161, 111, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(33013, 58, 28, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 13, 199, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(102, 632, 318, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(203, 7, 211, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 469, 146, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 417, 143, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(1061, 529, 329, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 4, 215, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 36, 182, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 14, 183, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 0, 182, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 429, 144, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 144, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 477, 144, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 500, 144, 0, 13014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 509, 144, 0, 13014));
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

