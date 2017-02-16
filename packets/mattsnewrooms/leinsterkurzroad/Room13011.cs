using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13011 : Room
  {
        public Room13011()
            : base(13011, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 104, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 104, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 138, 105, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 65532, 103, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 478, 127, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 668, 154, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 223, 120, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 216, 219, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 250, 328, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 468, 328, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(33012, 25, 67, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 260, 308, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 489, 251, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32980, 75, 219, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(210, 228, 220, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(33004, 560, 135, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(247, 394, 207, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(33006, 508, 147, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(33004, 614, 128, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32984, 441, 178, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32984, 427, 186, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 463, 168, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 307, 235, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 307, 249, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 424, 205, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 413, 209, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 9, 265, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65531, 286, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 1, 221, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65531, 198, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 632, 144, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 646, 161, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 642, 122, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 646, 182, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 640, 106, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 640, 88, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 8, 260, 0, 13011));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 628, 150, 0, 13011));
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

