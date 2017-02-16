using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3004 : Room
  {
        public Room3004()
            : base(3004, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 280, 136, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(3742, 483, 114, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 537, 133, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 507, 132, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 125, 131, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 92, 133, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 296, 131, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 628, 144, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 22, 215, 17, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 447, 218, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 189, 238, 11, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 598, 143, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 392, 136, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 332, 137, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 140, 137, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 609, 134, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 242, 140, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 70, 137, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 468, 136, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 511, 139, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 8, 134, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 128, 275, 27, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 431, 221, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 52, 207, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 32, 208, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 310, 248, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32813, 594, 260, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 197, 241, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 139, 260, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 99, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 437, 227, 24, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 600, 261, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 429, 222, 0, 3004));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 152, 261, 0, 3004));
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

