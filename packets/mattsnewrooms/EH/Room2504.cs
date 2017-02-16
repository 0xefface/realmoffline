using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2504 : Room
  {
        public Room2504()
            : base(2504, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 280, 136, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(35510, 483, 114, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 537, 133, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 507, 132, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 125, 131, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 92, 133, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 296, 131, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 628, 144, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 130, 260, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 80, 199, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 148, 248, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 598, 143, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 417, 140, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 268, 138, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 140, 137, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 609, 134, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 333, 139, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 76, 137, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 478, 136, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 538, 139, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 8, 134, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 59, 271, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 431, 221, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 52, 207, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 32, 208, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 307, 246, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(32813, 598, 254, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 223, 237, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(32813, 117, 251, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 99, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 308, 174, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 91, 251, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 448, 211, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 523, 250, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(32994, 599, 260, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 555, 316, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 392, 287, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 284, 221, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 211, 229, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 194, 241, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 15, 213, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 588, 271, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 479, 223, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 53, 165, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 209, 167, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 136, 170, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 352, 193, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 323, 223, 0, 2504));
          this.AddRoomDecoration(RoomDecoration.FromCode(32953, 321, 212, 0, 2504));
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

