using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3039 : Room
  {
        public Room3039()
            : base(3039, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 77, 124, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 573, 134, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 615, 130, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 553, 129, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 327, 140, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 136, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 78, 133, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 415, 268, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 406, 261, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 137, 222, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 221, 220, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 43, 207, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 22, 210, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 104, 228, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 104, 227, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 288, 139, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 312, 139, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 334, 138, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 366, 146, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 389, 146, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 357, 138, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 73, 132, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 430, 138, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 452, 138, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 476, 138, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 501, 135, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 135, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 540, 135, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 567, 128, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 590, 128, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 606, 128, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 128, 0, 3039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 249, 125, 0, 3039));
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

