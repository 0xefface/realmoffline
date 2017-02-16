using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3005 : Room
  {
        public Room3005()
            : base(3005, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 114, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 537, 133, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 507, 132, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 125, 131, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 92, 133, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 296, 131, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 41, 256, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 433, 195, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 199, 221, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 628, 144, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(32813, 547, 324, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 392, 136, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 332, 137, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 140, 137, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 609, 134, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(32920, 242, 140, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 70, 137, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 468, 136, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 511, 139, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 8, 134, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(32813, 143, 269, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 541, 91, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 322, 147, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 457, 150, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 517, 152, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 393, 144, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 26, 141, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 566, 152, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 614, 153, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 547, 171, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 553, 221, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 333, 254, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 148, 279, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 566, 328, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 639, 300, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 639, 314, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 330, 267, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 544, 260, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 417, 192, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 431, 202, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 382, 150, 0, 3005));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 101, 0, 3005));
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
