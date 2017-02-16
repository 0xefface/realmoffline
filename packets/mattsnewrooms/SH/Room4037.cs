using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4037 : Room
  {
        public Room4037()
            : base(4037, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 410, 103, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 586, 105, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 82, 103, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 80, 103, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 527, 114, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 110, 117, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 173, 314, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 280, 239, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 282, 103, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 239, 169, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 49, 189, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 411, 195, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 567, 193, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 27, 189, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 173, 193, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 91, 204, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 355, 196, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 420, 211, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 438, 196, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 597, 212, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 531, 194, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 282, 104, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 184, 324, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 134, 324, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 264, 181, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 286, 127, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 274, 163, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 319, 191, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 173, 191, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 254, 186, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 303, 210, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 267, 170, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 247, 198, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 202, 118, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 226, 118, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 85, 117, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 118, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 40, 118, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 18, 118, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 116, 0, 4037));
          this.AddRoomDecoration(RoomDecoration.FromCode(107, 65521, 315, 0, 4037));
          this.AllowCasting = False;
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

