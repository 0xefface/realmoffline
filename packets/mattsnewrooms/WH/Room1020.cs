using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1020 : Room
  {
        public Room1020()
            : base(1020, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 206, 104, 0, 1020));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 209, 215, 0, 1020));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 450, 313, 0, 1020));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 557, 160, 0, 1020));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 22, 115, 0, 1020));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 21, 113, 0, 1020));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 569, 159, 0, 1020));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 226, 224, 0, 1020));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 580, 161, 0, 1020));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 23, 114, 0, 1020));
          this.AddRoomDecoration(RoomDecoration.FromCode(33010, 456, 39, 0, 1020));
          this.AddRoomDecoration(RoomDecoration.FromCode(32941, 438, 103, 0, 1020));
          this.AddRoomDecoration(RoomDecoration.FromCode(141, 70, 88, 0, 1020));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 581, 160, 0, 1020));
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

