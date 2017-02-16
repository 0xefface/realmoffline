using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2036 : Room
  {
        public Room2036()
            : base(2036, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 252, 105, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 643, 103, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 139, 103, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 72, 104, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 421, 122, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 529, 115, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 49, 116, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 530, 197, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 534, 198, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(102, 5, 317, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 144, 204, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 353, 203, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 545, 201, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 458, 204, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 245, 205, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 635, 203, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 470, 121, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(240, 62, 65, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 200, 108, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 124, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 328, 126, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 352, 124, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 123, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 90, 215, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 273, 213, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 456, 214, 0, 2036));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 597, 212, 0, 2036));
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

