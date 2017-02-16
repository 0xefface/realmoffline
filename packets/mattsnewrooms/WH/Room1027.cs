using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1027 : Room
  {
        public Room1027()
            : base(1027, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 59, 300, 0, 1027));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 421, 227, 0, 1027));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 147, 249, 0, 1027));
          this.AddRoomDecoration(RoomDecoration.FromCode(125, 423, 221, 65526, 1027));
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 610, 105, 0, 1027));
          this.AddRoomDecoration(RoomDecoration.FromCode(33014, 613, 78, 0, 1027));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 138, 106, 0, 1027));
          this.AddRoomDecoration(RoomDecoration.FromCode(245, 52, 60, 0, 1027));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 115, 251, 0, 1027));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 283, 250, 0, 1027));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 450, 255, 0, 1027));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 554, 250, 0, 1027));
          this.AddRoomDecoration(RoomDecoration.FromCode(32914, 80, 106, 25, 1027));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 617, 102, 0, 1027));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 420, 232, 0, 1027));
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

