using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2029 : Room
  {
        public Room2029()
            : base(2029, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 459, 102, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 103, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 658, 133, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 50, 121, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 284, 283, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 401, 144, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 291, 285, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 297, 274, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 64, 167, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 380, 191, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 427, 299, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 396, 202, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 323, 167, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 395, 215, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(203, 422, 146, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 412, 146, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 477, 115, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 195, 166, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 537, 133, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 133, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 133, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 133, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 133, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 60, 173, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 194, 173, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 313, 173, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 378, 197, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 374, 207, 0, 2029));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 378, 247, 0, 2029));
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

