using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4011 : Room
  {
        public Room4011()
            : base(4011, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(106, 101, 317, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 153, 106, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 518, 105, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2539, 315, 107, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32962, 324, 102, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 375, 117, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 40, 117, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 593, 126, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 527, 118, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(33000, 310, 105, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 318, 102, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 310, 127, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 409, 210, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 569, 172, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(195, 69, 51, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(197, 523, 54, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 319, 169, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 331, 226, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 320, 103, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 302, 105, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 482, 202, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 502, 195, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 316, 127, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 376, 266, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 361, 116, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 386, 116, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 494, 116, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 517, 116, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 538, 115, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 555, 115, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 568, 126, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 591, 126, 0, 4011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 614, 126, 0, 4011));
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

