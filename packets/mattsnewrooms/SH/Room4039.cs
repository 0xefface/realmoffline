using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4039 : Room
  {
        public Room4039()
            : base(4039, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 557, 127, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 99, 118, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 111, 188, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 75, 187, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 106, 192, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(32943, 172, 108, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 250, 195, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 400, 194, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 567, 191, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 524, 243, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 126, 217, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 33, 216, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 268, 211, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 366, 194, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 506, 211, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 617, 193, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 201, 197, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 571, 243, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(32920, 40, 114, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 136, 129, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(32920, 572, 132, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 442, 126, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 220, 111, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 556, 238, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 65, 186, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 83, 198, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 147, 131, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 169, 131, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 417, 126, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 441, 127, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 462, 127, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 485, 129, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 127, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 127, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 132, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 601, 132, 0, 4039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 128, 0, 4039));
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

