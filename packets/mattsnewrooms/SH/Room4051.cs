using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4051 : Room
  {
        public Room4051()
            : base(4051, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 103, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 481, 117, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 678, 125, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 29, 319, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 599, 322, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 446, 106, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 102, 211, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 122, 207, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 315, 135, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 129, 206, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 91, 205, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 41, 135, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 454, 142, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 168, 133, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 285, 138, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 343, 148, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 276, 136, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 302, 139, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 324, 140, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 344, 140, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 364, 141, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 376, 141, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 323, 148, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 191, 133, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 168, 133, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 265, 139, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 282, 139, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 444, 140, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 468, 141, 0, 4051));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 51, 135, 0, 4051));
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

