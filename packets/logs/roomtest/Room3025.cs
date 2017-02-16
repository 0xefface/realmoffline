using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3025 : Room
  {
        public Room3025()
            : base(3025, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65465, 124, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 587, 135, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 344, 124, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 491, 136, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 145, 142, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 561, 148, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 214, 142, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 30, 138, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 394, 146, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 145, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 39, 208, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 304, 248, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 23, 209, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 321, 256, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(121, 152, 326, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 346, 247, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 442, 264, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 450, 269, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 66, 126, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 603, 136, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 551, 119, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 164, 114, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 155, 141, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 173, 141, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 204, 141, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 228, 142, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 329, 140, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 146, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 145, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 415, 145, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 113, 140, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 491, 145, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 144, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 535, 144, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 562, 147, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 147, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 464, 135, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 487, 135, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 135, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 143, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 139, 0, 3025));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 609, 146, 0, 3025));
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

