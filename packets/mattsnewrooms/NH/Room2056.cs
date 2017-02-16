using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2056 : Room
  {
        public Room2056()
            : base(2056, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 603, 323, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 557, 249, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 84, 182, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 531, 275, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 92, 196, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 308, 103, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 90, 102, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 4, 115, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 478, 116, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 396, 235, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 303, 102, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(245, 187, 46, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 64, 194, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 97, 178, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 550, 252, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 71, 175, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 88, 174, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 569, 326, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 135, 185, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 366, 180, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 303, 121, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 385, 240, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 325, 158, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 356, 172, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 333, 164, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 337, 171, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 351, 182, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 362, 191, 0, 2056));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 675, 239, 0, 2056));
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

