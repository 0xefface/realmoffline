using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2019 : Room
  {
        public Room2019()
            : base(2019, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 308, 103, 0, 2019));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 125, 115, 0, 2019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 370, 226, 0, 2019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 369, 240, 0, 2019));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 306, 228, 0, 2019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 367, 230, 0, 2019));
          this.AddRoomDecoration(RoomDecoration.FromCode(241, 463, 1, 0, 2019));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 526, 116, 0, 2019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 245, 117, 0, 2019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 118, 0, 2019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 197, 117, 0, 2019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 405, 118, 0, 2019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 119, 0, 2019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 451, 118, 0, 2019));
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

