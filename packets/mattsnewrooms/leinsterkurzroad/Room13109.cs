using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13109 : Room
  {
        public Room13109()
            : base(13109, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 104, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 469, 104, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 104, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 351, 131, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 666, 133, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 65528, 125, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 84, 320, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 439, 209, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 605, 319, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 279, 197, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(244, 552, 67, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 128, 231, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 366, 224, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(32994, 277, 231, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 584, 213, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 371, 224, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 270, 252, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 188, 296, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 309, 202, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 116, 107, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 431, 219, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 9, 126, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 33, 125, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 125, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 73, 127, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 104, 127, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 233, 130, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 256, 131, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 280, 133, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 131, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 327, 130, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 351, 131, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 131, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 398, 131, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 462, 132, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 553, 135, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 577, 135, 0, 13109));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 134, 0, 13109));
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

