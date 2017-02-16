using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3001 : Room
  {
        public Room3001()
            : base(3001, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 288, 132, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 114, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 537, 133, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 507, 132, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 125, 131, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 92, 133, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 318, 122, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 392, 136, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 360, 138, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 140, 137, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 609, 134, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 70, 137, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 468, 136, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 511, 139, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 8, 134, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 214, 137, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 236, 142, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 24, 219, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 610, 266, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 569, 268, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 205, 220, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 470, 238, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 563, 269, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 501, 323, 65530, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 114, 245, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 0, 222, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 612, 278, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 519, 278, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 304, 284, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 63, 285, 0, 3001));
          this.AddRoomDecoration(RoomDecoration.FromCode(110, 207, 221, 65533, 3001));
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

