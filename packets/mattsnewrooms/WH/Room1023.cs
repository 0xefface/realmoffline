using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1023 : Room
  {
        public Room1023()
            : base(1023, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Right;
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 238, 103, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(125, 557, 151, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 463, 217, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 565, 156, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32881, 465, 213, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 440, 186, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 444, 203, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 507, 211, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32958, 592, 146, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 454, 212, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 491, 212, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32964, 577, 142, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(245, 363, 57, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(33013, 400, 29, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 90, 116, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 441, 105, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 293, 106, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 229, 101, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 419, 218, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 595, 173, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 612, 199, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32966, 679, 89, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 625, 193, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 608, 170, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 599, 152, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 578, 142, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 562, 123, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 557, 112, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 560, 98, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 635, 209, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 615, 185, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 601, 166, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 583, 155, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 565, 138, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 13, 116, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 116, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 116, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 115, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 106, 115, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 130, 114, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 154, 117, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 265, 107, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 199, 117, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 176, 117, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 288, 107, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 311, 107, 0, 1023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 335, 107, 0, 1023));
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

