using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4015 : Room
  {
        public Room4015()
            : base(4015, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 515, 108, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 40, 108, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 310, 236, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 222, 197, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 536, 295, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 134, 320, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 292, 237, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 104, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 545, 288, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 606, 327, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 248, 195, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 62, 114, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 605, 123, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 515, 120, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 307, 234, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 208, 247, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(32983, 13, 249, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(219, 178, 177, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(32982, 157, 245, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(214, 135, 170, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(216, 74, 140, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(216, 56, 130, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(215, 111, 140, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(238, 17, 109, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 147, 210, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(110, 21, 134, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(110, 65532, 133, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 318, 226, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 281, 225, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 184, 247, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 43, 113, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 67, 113, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 504, 119, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 122, 169, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 67, 144, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 119, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 121, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 616, 121, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(218, 197, 206, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 250, 205, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 157, 174, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(110, 164, 174, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 201, 179, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 144, 174, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 216, 184, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 101, 169, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 207, 201, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 183, 200, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 82, 295, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 148, 288, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 183, 283, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 83, 232, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 151, 291, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 266, 319, 0, 4015));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 34, 130, 0, 4015));
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

