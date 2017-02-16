using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1028 : Room
  {
        public Room1028()
            : base(1028, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 548, 320, 0, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 27, 321, 0, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 558, 236, 0, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 130, 148, 0, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 136, 149, 0, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 426, 105, 0, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 156, 39, 0, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32941, 501, 105, 0, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 172, 107, 0, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 434, 92, 0, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 345, 99, 0, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 659, 116, 0, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 100, 261, 0, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 278, 267, 0, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(142, 324, 102, 0, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(141, 54, 111, 20, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 578, 106, 0, 1028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 595, 106, 0, 1028));
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

