using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4022 : Room
  {
        public Room4022()
            : base(4022, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 290, 103, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 586, 105, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 65496, 104, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 105, 116, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 677, 128, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 514, 210, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 513, 217, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 4, 126, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 105, 126, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 293, 143, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(33002, 286, 104, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 289, 129, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 74, 103, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 459, 106, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 275, 182, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 296, 238, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 7, 126, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 29, 126, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 73, 126, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 95, 126, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 119, 126, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 143, 126, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 579, 128, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 129, 0, 4022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 129, 0, 4022));
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

