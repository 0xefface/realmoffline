using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1011 : Room
  {
        public Room1011()
            : base(1011, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Right;
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 317, 102, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 71, 252, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32881, 147, 273, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 73, 249, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 188, 216, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 184, 219, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32958, 608, 193, 50, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 300, 316, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 779, 143, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(240, 275, 1, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 511, 216, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(33000, 495, 148, 20, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 92, 111, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 482, 107, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 173, 101, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 394, 93, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 0, 102, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 598, 140, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(197, 662, 85, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 499, 94, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 494, 155, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 537, 299, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 514, 204, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 112, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 147, 112, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 658, 319, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 604, 130, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 602, 107, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 112, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 112, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 107, 273, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 601, 144, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 402, 107, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 425, 107, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 448, 108, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 470, 108, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 518, 108, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 534, 107, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 555, 109, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 578, 109, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 207, 111, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 111, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 162, 111, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 130, 112, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 106, 112, 0, 1011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 112, 0, 1011));
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

