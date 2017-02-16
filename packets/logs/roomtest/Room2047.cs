using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2047 : Room
  {
        public Room2047()
            : base(2047, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Down;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 68, 117, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 429, 111, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 289, 103, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 440, 319, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 55, 280, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 30, 278, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(246, 207, 43, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(32943, 209, 94, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(33003, 420, 233, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(33003, 146, 184, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 549, 262, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 28, 292, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 7, 207, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(32944, 829, 104, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 62, 165, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 264, 203, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 299, 207, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 707, 311, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 544, 248, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 315, 199, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(33003, 429, 222, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 223, 194, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 62, 158, 0, 2047));
          this.AddRoomDecoration(RoomDecoration.FromCode(33003, 142, 173, 0, 2047));
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

