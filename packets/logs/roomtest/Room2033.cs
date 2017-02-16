using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2033 : Room
  {
        public Room2033()
            : base(2033, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 608, 312, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 535, 274, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 84, 182, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 530, 258, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 651, 274, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 248, 103, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 65507, 104, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 0, 123, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 452, 174, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 573, 173, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 342, 190, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 375, 200, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 305, 243, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 344, 210, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 177, 103, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 526, 112, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(244, 214, 39, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 297, 239, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 616, 320, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 541, 270, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 75, 175, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 95, 183, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 327, 241, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 317, 208, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 363, 184, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 475, 182, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 581, 183, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 342, 201, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 356, 197, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 378, 190, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 322, 181, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 338, 181, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 335, 111, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 341, 105, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 338, 124, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 335, 147, 0, 2033));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 344, 150, 0, 2033));
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

