using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4014 : Room
  {
        public Room4014()
            : base(4014, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Up;
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 421, 234, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 7, 329, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 26, 330, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 416, 235, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 184, 103, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 500, 104, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 564, 112, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 633, 106, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 9, 117, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 512, 123, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 104, 114, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(243, 106, 27, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 593, 123, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 505, 128, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 87, 209, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 336, 193, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 347, 188, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 172, 115, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(32963, 616, 47, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(194, 172, 87, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 617, 330, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(198, 58, 45, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 411, 129, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 366, 145, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 255, 206, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 341, 198, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 501, 121, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 528, 122, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 24, 117, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 143, 115, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 164, 115, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 188, 116, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 206, 116, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 120, 116, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 96, 116, 0, 4014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 72, 116, 0, 4014));
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

