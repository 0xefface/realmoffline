using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3020 : Room
  {
        public Room3020()
            : base(3020, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 77, 124, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 552, 128, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 290, 134, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 503, 131, 7, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 626, 134, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 141, 135, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 572, 129, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 411, 125, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 230, 143, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 391, 140, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 498, 113, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 77, 132, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 23, 131, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 85, 206, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 376, 255, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 328, 254, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 93, 213, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 443, 111, 13, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 454, 104, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 296, 112, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 475, 237, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 408, 207, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 512, 217, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 211, 224, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 552, 225, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 368, 302, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 239, 225, 23, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 588, 104, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 461, 174, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 452, 130, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 7, 131, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 30, 131, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 50, 131, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 125, 136, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 135, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 135, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 246, 142, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 223, 144, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 295, 140, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 313, 140, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 479, 123, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 561, 126, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 583, 126, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 604, 135, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 135, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 585, 136, 0, 3020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 497, 123, 0, 3020));
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

