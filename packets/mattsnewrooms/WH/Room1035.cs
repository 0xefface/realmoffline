using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1035 : Room
  {
        public Room1035()
            : base(1035, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 238, 103, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 317, 150, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32881, 327, 145, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 328, 142, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32958, 573, 139, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32964, 572, 137, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 356, 174, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 602, 250, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32959, 622, 212, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 539, 203, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 271, 214, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 48, 213, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 165, 226, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 155, 215, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 173, 105, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 345, 106, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 180, 106, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 228, 103, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 31, 111, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32965, 707, 70, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 405, 209, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 541, 110, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 562, 144, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 632, 308, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 631, 288, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 631, 265, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 638, 246, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 628, 232, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 597, 178, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 584, 158, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 550, 121, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 557, 131, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 601, 192, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 590, 170, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 575, 148, 0, 1035));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 539, 96, 0, 1035));
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

