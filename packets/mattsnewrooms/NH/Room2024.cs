using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2024 : Room
  {
        public Room2024()
            : base(2024, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 107, 111, 0, 2024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 2024));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 518, 154, 0, 2024));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 541, 226, 0, 2024));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 585, 156, 0, 2024));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 545, 227, 0, 2024));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 583, 159, 0, 2024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32943, 309, 103, 0, 2024));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 0, 11, 0, 2024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 452, 116, 0, 2024));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 123, 0, 2024));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 495, 124, 0, 2024));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 124, 0, 2024));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 124, 0, 2024));
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

