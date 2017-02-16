using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1030 : Room
  {
        public Room1030()
            : base(1030, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Left;
          this.AddRoomDecoration(RoomDecoration.FromCode(32910, 240, 74, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 65507, 235, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 60, 328, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 241, 223, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 126, 188, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 161, 197, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 33, 185, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(32868, 150, 184, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(32834, 227, 192, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 340, 111, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 187, 184, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 484, 318, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 241, 224, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(240, 477, 56, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(32941, 153, 104, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 548, 108, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 63, 192, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 110, 198, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(32834, 259, 189, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(32834, 299, 182, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 59, 318, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 19, 105, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 6, 119, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 38, 319, 0, 1030));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 10, 206, 0, 1030));
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

