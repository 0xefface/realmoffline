using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3019 : Room
  {
        public Room3019()
            : base(3019, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 85, 122, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 299, 136, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 443, 139, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 146, 142, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 152, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 200, 156, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 326, 140, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 253, 161, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 384, 151, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 525, 150, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 78, 133, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 17, 125, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(102, 646, 318, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 53, 206, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 151, 238, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 223, 236, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 74, 219, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 497, 232, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 434, 220, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 505, 218, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 165, 122, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 145, 245, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 235, 237, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 61, 207, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 428, 221, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 190, 154, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 126, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 96, 131, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 116, 141, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 249, 161, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 271, 160, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 295, 139, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 318, 140, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 338, 139, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 359, 138, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 365, 150, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 389, 150, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 149, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 560, 151, 0, 3019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 151, 0, 3019));
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

