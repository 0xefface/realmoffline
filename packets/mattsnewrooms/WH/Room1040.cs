using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1040 : Room
  {
        public Room1040()
            : base(1040, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 580, 322, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 303, 332, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 551, 216, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 593, 205, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 513, 204, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 554, 215, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 91, 104, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(33009, 65, 68, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 119, 100, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 561, 112, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 143, 111, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 611, 113, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 696, 98, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(145, 5, 111, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 619, 108, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 540, 107, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 571, 106, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 490, 112, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 512, 113, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 113, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 560, 113, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 584, 113, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 608, 113, 0, 1040));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 632, 114, 0, 1040));
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

