using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1022 : Room
  {
        public Room1022()
            : base(1022, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 326, 104, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32830, 326, 244, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 127, 256, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 344, 255, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 261, 258, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 382, 246, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 306, 262, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 235, 265, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 290, 244, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 133, 257, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 466, 165, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 330, 248, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 154, 232, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 90, 232, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 297, 254, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 453, 170, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 490, 167, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 432, 163, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 610, 164, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 615, 167, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 466, 166, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(33009, 592, 56, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 360, 102, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 561, 120, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 435, 120, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 428, 120, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 119, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 119, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 498, 119, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 522, 119, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 547, 119, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 570, 119, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 597, 119, 0, 1022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 620, 119, 0, 1022));
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

