using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1016 : Room
  {
        public Room1016()
            : base(1016, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 303, 328, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 53, 321, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 27, 219, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 263, 184, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 163, 175, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 52, 216, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 19, 189, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 21, 178, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 325, 187, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 476, 183, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 585, 167, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 288, 170, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 423, 168, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 561, 166, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 551, 318, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 75, 188, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 163, 187, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 293, 170, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 395, 183, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 557, 183, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 402, 167, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 503, 168, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 321, 106, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 65489, 102, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 640, 316, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 520, 111, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 319, 101, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 155, 173, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 17, 174, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 403, 112, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 426, 112, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 443, 112, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 467, 110, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 491, 110, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 513, 110, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 110, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 111, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 112, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 611, 112, 0, 1016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 624, 112, 0, 1016));
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

