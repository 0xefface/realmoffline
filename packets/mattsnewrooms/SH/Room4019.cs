using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4019 : Room
  {
        public Room4019()
            : base(4019, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 396, 105, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 179, 116, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 407, 228, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 364, 244, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 305, 233, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 363, 234, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 53, 132, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 604, 131, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 357, 238, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 567, 134, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 604, 127, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 23, 134, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 65400, 103, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 527, 108, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 17, 131, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 40, 133, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 131, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 86, 132, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 578, 131, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 601, 130, 0, 4019));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 131, 0, 4019));
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

