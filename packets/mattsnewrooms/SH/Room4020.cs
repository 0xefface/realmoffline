using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4020 : Room
  {
        public Room4020()
            : base(4020, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 132, 104, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 65480, 103, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 516, 116, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 185, 109, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 346, 105, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 521, 239, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 528, 237, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 32, 118, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 123, 120, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(32944, 583, 105, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(32944, 98, 104, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 543, 236, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 74, 122, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 3, 321, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 153, 122, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 132, 121, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 122, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 87, 122, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 64, 123, 0, 4020));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 41, 124, 0, 4020));
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

