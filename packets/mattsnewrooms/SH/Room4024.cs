using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4024 : Room
  {
        public Room4024()
            : base(4024, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 94, 110, 0, 4024));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 4024));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 197, 187, 0, 4024));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 74, 135, 0, 4024));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 33, 128, 0, 4024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 412, 268, 0, 4024));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 415, 278, 0, 4024));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 190, 190, 0, 4024));
          this.AddRoomDecoration(RoomDecoration.FromCode(32943, 312, 104, 0, 4024));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 135, 0, 4024));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 70, 135, 0, 4024));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 127, 0, 4024));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 127, 0, 4024));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 56, 127, 0, 4024));
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

