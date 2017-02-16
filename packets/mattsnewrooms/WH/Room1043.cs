using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1043 : Room
  {
        public Room1043()
            : base(1043, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 352, 103, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 402, 174, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 65526, 248, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(32979, 377, 250, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(210, 91, 252, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(142, 262, 103, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 145, 105, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 65436, 95, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 48, 334, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 568, 245, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 255, 103, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(209, 233, 246, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 239, 188, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 239, 191, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 250, 148, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 169, 298, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 294, 298, 0, 1043));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 249, 121, 0, 1043));
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

