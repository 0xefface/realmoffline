using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1006 : Room
  {
        public Room1006()
            : base(1006, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 98, 106, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 60, 110, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 71, 347, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 47, 101, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 34, 109, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 78, 105, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 63, 105, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 604, 202, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 92, 98, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 341, 102, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 114, 110, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 33, 192, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 484, 318, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 338, 106, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 286, 35, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 491, 110, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 428, 33, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 321, 109, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 71, 109, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32909, 612, 93, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(142, 616, 96, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 89, 110, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 488, 199, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 331, 193, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 182, 193, 0, 1006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32834, 122, 364, 0, 1006));
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

