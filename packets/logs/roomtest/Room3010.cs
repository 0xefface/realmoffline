using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3010 : Room
  {
        public Room3010()
            : base(3010, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 539, 142, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 122, 133, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 187, 138, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(102, 5, 318, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 467, 273, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 573, 264, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 364, 143, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 373, 148, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 269, 249, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 443, 265, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 280, 248, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 208, 222, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 584, 258, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 330, 180, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 278, 173, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 123, 176, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 622, 178, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 205, 188, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 102, 197, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 346, 103, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 422, 176, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 563, 175, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 405, 192, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 490, 190, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 571, 191, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 475, 175, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 327, 144, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 315, 173, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 319, 141, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 144, 176, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 550, 177, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 406, 174, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 210, 225, 15, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 352, 246, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 132, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 117, 132, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 140, 132, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 161, 135, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 504, 140, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 140, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 547, 139, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 142, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 392, 137, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 340, 137, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 357, 137, 0, 3010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 375, 137, 0, 3010));
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

