using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2502 : Room
  {
        public Room2502()
            : base(2502, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 280, 136, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(35510, 429, 116, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 537, 133, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 507, 132, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 100, 133, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 92, 133, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 296, 131, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 41, 208, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 185, 205, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 447, 218, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 75, 241, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 598, 143, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 392, 136, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 332, 137, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 140, 137, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 609, 134, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 243, 143, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 103, 136, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 478, 137, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 549, 139, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 35, 136, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 104, 264, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(35720, 93, 235, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(121, 617, 326, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 516, 223, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 437, 221, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(35719, 316, 245, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 145, 237, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(32818, 189, 186, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 120, 238, 0, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 193, 188, 8, 2502));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 316, 246, 0, 2502));
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

