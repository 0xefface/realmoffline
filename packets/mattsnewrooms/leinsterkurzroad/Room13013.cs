using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13013 : Room
  {
        public Room13013()
            : base(13013, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 248, 111, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 83, 131, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 413, 240, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 48, 262, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(241, 463, 1, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 559, 123, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 65532, 332, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 227, 142, 30, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 328, 257, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 277, 245, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 450, 328, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 650, 213, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 228, 135, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 245, 173, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 279, 228, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 300, 238, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 635, 208, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 617, 208, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 227, 217, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 204, 221, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 320, 245, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 300, 250, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 301, 254, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 253, 168, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 58, 219, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 283, 212, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 293, 219, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 302, 227, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 355, 242, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 383, 258, 0, 13013));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 177, 219, 0, 13013));
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

