using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3007 : Room
  {
        public Room3007()
            : base(3007, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 585, 134, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 303, 138, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 461, 141, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 539, 137, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 184, 141, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 95, 125, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 341, 140, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 25, 139, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 219, 149, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 500, 145, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32889, 95, 324, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 261, 152, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 312, 252, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 433, 218, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 610, 256, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 92, 144, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 281, 145, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 386, 140, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 353, 256, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 358, 246, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 163, 236, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 438, 219, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 589, 257, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 61, 143, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 138, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 81, 143, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 104, 143, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 202, 140, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 224, 140, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 172, 141, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 506, 134, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 479, 136, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 530, 134, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 458, 136, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 553, 134, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 570, 134, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 334, 138, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 357, 138, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 250, 145, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 267, 145, 0, 3007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 285, 145, 0, 3007));
          this.AllowCasting = False;
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

