using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13105 : Room
  {
        public Room13105()
            : base(13105, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 308, 105, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 184, 124, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 407, 228, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 372, 252, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 306, 228, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 31, 259, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(241, 462, 39, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 426, 138, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 32, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 604, 343, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 628, 166, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 536, 159, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 94, 152, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 26, 274, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 250, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 462, 161, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 286, 94, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 317, 157, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 637, 164, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 155, 200, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(203, 186, 195, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 355, 151, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 415, 259, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 439, 270, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 398, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 136, 202, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 160, 192, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 182, 192, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 205, 192, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 139, 192, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 115, 192, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 586, 160, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 604, 160, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 622, 160, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 639, 161, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 552, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 564, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 576, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 540, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 528, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 516, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 504, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 493, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 482, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 471, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 459, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 447, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 436, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 425, 156, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 372, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 383, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 362, 147, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 355, 148, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 350, 147, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 362, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 394, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 351, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 339, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 327, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 316, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 304, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 292, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 280, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 268, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 256, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 245, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 233, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 221, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 210, 154, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 76, 152, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 65, 152, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 54, 152, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 42, 151, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 3, 152, 0, 13105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 15, 152, 0, 13105));
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

