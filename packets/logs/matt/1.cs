using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2059 : Room
  {
        public Room2059()
            : base(2059, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Down;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 102, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 202, 105, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 6, 103, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 362, 113, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 180, 173, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 561, 252, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 578, 244, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(33003, 229, 104, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 166, 170, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 176, 166, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(102, 65516, 317, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 485, 169, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 375, 163, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 585, 116, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 50, 112, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 596, 173, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 290, 155, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(33003, 272, 150, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 245, 122, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 627, 129, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 626, 206, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 620, 313, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 617, 250, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 611, 206, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 620, 297, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 130, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 130, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 360, 170, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 496, 175, 0, 2059));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 597, 165, 0, 2059));
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


