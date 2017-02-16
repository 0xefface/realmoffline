using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1004 : Room
  {
        public Room1004()
            : base(1004, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32940, 277, 102, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(172, 366, 104, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32940, 530, 102, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 310, 127, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 365, 237, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 583, 302, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 319, 124, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32834, 624, 300, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 52, 327, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 290, 160, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 137, 175, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 440, 237, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 136, 170, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 100, 172, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 340, 133, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 613, 296, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 169, 174, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 64, 171, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 324, 238, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 340, 131, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(241, 444, 1, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(171, 65385, 106, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 122, 117, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 525, 103, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(32932, 346, 112, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 116, 65526, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 521, 121, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 545, 121, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 568, 121, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 121, 0, 1004));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 615, 121, 0, 1004));
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

