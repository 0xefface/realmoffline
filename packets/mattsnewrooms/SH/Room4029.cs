using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4029 : Room
  {
        public Room4029()
            : base(4029, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 644, 103, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 103, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 374, 137, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 22, 318, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 408, 220, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 536, 320, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 422, 227, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(243, 105, 47, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 37, 319, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 614, 202, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 637, 324, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 599, 137, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 256, 135, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 280, 137, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 137, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 327, 138, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 351, 137, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 374, 137, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 439, 137, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 463, 139, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 487, 138, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 139, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 169, 124, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 146, 124, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 122, 124, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 99, 122, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 122, 0, 4029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 52, 121, 0, 4029));
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

