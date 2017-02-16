using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4034 : Room
  {
        public Room4034()
            : base(4034, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 308, 103, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 516, 118, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 118, 121, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 407, 228, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 351, 235, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 306, 228, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 398, 123, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 497, 128, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 43, 138, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 130, 133, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 498, 122, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 291, 233, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 82, 319, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 104, 230, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 318, 233, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 544, 262, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 624, 225, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 598, 230, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 539, 202, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 32, 254, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 155, 252, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 305, 255, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 349, 234, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 486, 240, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 16, 137, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 39, 136, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 136, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 138, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 103, 132, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 124, 132, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 148, 131, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 159, 131, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 365, 122, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 389, 121, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 413, 122, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 436, 122, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 469, 127, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 491, 127, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 127, 0, 4034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 533, 127, 0, 4034));
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

