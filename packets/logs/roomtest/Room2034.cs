using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2034 : Room
  {
        public Room2034()
            : base(2034, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 372, 104, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 114, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 110, 122, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 50, 179, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 505, 395, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 190, 180, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 321, 222, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 439, 226, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 639, 226, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 271, 199, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(243, 365, 41, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 289, 210, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 310, 215, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 285, 206, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 124, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 124, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 12, 295, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 69, 187, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 182, 187, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 271, 210, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 289, 217, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 306, 224, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 448, 236, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 327, 229, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 347, 235, 0, 2034));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 537, 237, 0, 2034));
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

