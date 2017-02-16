using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4040 : Room
  {
        public Room4040()
            : base(4040, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 512, 113, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32943, 380, 105, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32818, 60, 247, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 61, 249, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 173, 117, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 535, 126, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 87, 118, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 616, 125, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 88, 241, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 79, 191, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 412, 187, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 564, 188, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 373, 190, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 304, 204, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 183, 206, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 525, 204, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 597, 206, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 257, 113, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 587, 131, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 252, 190, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(110, 79, 243, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(110, 107, 248, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 568, 129, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 593, 129, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 506, 125, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 125, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 552, 125, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 610, 124, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 630, 124, 0, 4040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 120, 0, 4040));
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

