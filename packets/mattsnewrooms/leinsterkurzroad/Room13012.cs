using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13012 : Room
  {
        public Room13012()
            : base(13012, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 104, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 105, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 104, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 428, 130, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 666, 131, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 29, 319, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 5, 353, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 11, 269, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(33012, 25, 67, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 7, 162, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(32925, 32, 237, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 27, 156, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 629, 355, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 628, 186, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 36, 277, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(180, 49, 286, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 203, 157, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 64, 155, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 42, 155, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 160, 155, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 181, 155, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 204, 155, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 228, 155, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 244, 155, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 594, 184, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 617, 184, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 630, 184, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 71, 188, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 198, 188, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 308, 190, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 425, 191, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 566, 191, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 161, 224, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 211, 225, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 416, 221, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 508, 220, 0, 13012));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 344, 241, 0, 13012));
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

