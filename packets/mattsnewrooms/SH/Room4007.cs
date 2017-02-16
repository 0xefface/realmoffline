using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4007 : Room
  {
        public Room4007()
            : base(4007, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 57, 322, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 191, 206, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 190, 211, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 47, 301, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 188, 213, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 130, 106, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 500, 105, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2539, 296, 109, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(195, 301, 101, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(33000, 286, 103, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 306, 103, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 306, 218, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 291, 166, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 397, 104, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 247, 104, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32925, 171, 126, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 360, 109, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 590, 117, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(194, 26, 86, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32963, 623, 52, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 294, 103, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 284, 124, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 314, 145, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 328, 289, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 141, 126, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 164, 125, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 126, 123, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 551, 116, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 117, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 596, 115, 0, 4007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 620, 117, 0, 4007));
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

