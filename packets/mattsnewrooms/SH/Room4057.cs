using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4057 : Room
  {
        public Room4057()
            : base(4057, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 308, 103, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 106, 114, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 520, 110, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 431, 231, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 324, 224, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 292, 243, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 383, 255, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 454, 261, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 612, 121, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 566, 123, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 331, 252, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 43, 129, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 425, 121, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 110, 136, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 338, 271, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 367, 275, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(32830, 450, 277, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 15, 128, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 128, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 128, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 73, 128, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 104, 134, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 123, 134, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 409, 120, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 430, 120, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 122, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 568, 122, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 592, 122, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 616, 120, 0, 4057));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 623, 120, 0, 4057));
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

