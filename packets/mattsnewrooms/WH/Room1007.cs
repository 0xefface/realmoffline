using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1007 : Room
  {
        public Room1007()
            : base(1007, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 158, 105, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 402, 174, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32830, 157, 285, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 260, 273, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 46, 210, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 553, 295, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 265, 266, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 50, 209, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 153, 287, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 546, 296, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 423, 171, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 368, 104, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(244, 55, 28, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 432, 171, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32909, 32, 88, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 197, 277, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 398, 174, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 248, 221, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 251, 207, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 100, 206, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 326, 230, 0, 1007));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 348, 235, 0, 1007));
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

