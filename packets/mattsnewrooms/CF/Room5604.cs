using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5604 : Room
  {
        public Room5604()
            : base(5604, "Clip 'n Crop")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.UpRight;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 124, 35, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 214, 64, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 300, 62, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 442, 45, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2613, 337, 71, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 221, 51, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 160, 40, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 201, 66, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 174, 62, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2628, 251, 74, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 362, 206, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 178, 163, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 379, 179, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 178, 157, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 558, 47, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 251, 239, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 56, 188, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 17, 184, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 646, 196, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 656, 198, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 613, 186, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 10, 167, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 601, 209, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 534, 204, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 570, 40, 65485, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65518, 34, 65437, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 17, 16, 65456, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 609, 35, 65437, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 601, 157, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2958, 77, 172, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2958, 58, 148, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(35726, 540, 200, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(35726, 540, 159, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 12, 132, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 596, 32, 65437, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 451, 198, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 468, 171, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2652, 468, 51, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 495, 59, 0, 5604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 565, 140, 50, 5604));
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

