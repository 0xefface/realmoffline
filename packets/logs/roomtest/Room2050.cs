using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2050 : Room
  {
        public Room2050()
            : base(2050, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 94, 102, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 65476, 103, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 490, 112, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 185, 112, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 462, 193, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 342, 201, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 348, 208, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 371, 224, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 462, 201, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 461, 219, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 462, 191, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 359, 199, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 419, 228, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 406, 210, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 33, 260, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 91, 266, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 77, 258, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 45, 264, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 22, 254, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 469, 192, 0, 2050));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 478, 105, 0, 2050));
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

