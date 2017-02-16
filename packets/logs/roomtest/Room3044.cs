using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3044 : Room
  {
        public Room3044()
            : base(3044, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 103, 122, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 573, 134, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 136, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 393, 141, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 529, 155, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 86, 132, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 582, 154, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 200, 156, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 253, 161, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 487, 142, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 615, 147, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 163, 143, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 35, 129, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 133, 224, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 640, 276, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 38, 209, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 448, 212, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 557, 281, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 310, 248, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 443, 215, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 222, 225, 5, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 374, 253, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 551, 278, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 412, 270, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 57, 212, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 418, 218, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 589, 327, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(32828, 62, 354, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 20, 323, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(1061, 316, 250, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 134, 230, 19, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 61, 132, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 83, 131, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 104, 131, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 9, 128, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 271, 160, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 247, 160, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 190, 154, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 493, 154, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 517, 154, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 541, 154, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 572, 151, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 591, 151, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 468, 141, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 491, 141, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 140, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 609, 145, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 236, 161, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 142, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 182, 142, 0, 3044));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 400, 138, 0, 3044));
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

