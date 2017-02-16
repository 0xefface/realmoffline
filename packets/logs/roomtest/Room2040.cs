using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2040 : Room
  {
        public Room2040()
            : base(2040, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 524, 115, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 130, 117, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 103, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 195, 175, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 22, 204, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 65494, 125, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 286, 171, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 377, 156, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 424, 153, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 411, 78, 65459, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 203, 191, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 502, 150, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 400, 158, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 518, 131, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(241, 208, 24, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 16, 188, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 63, 174, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 614, 167, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 442, 150, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 483, 166, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 423, 130, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 447, 132, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 469, 131, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 132, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 516, 133, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 131, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 563, 131, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 586, 131, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 610, 131, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 634, 131, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 63, 170, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 187, 168, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 309, 165, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 368, 160, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 381, 155, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 399, 151, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 413, 148, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 429, 146, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 487, 144, 0, 2040));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 606, 161, 0, 2040));
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

