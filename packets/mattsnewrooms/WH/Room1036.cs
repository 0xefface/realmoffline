using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1036 : Room
  {
        public Room1036()
            : base(1036, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 524, 178, 0, 1036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32868, 12, 269, 0, 1036));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 24, 239, 0, 1036));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 32, 185, 0, 1036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32834, 127, 203, 0, 1036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32834, 131, 199, 0, 1036));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 143, 189, 0, 1036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32868, 43, 135, 0, 1036));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 25, 197, 0, 1036));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 8, 320, 0, 1036));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 331, 102, 0, 1036));
          this.AddRoomDecoration(RoomDecoration.FromCode(121, 333, 328, 0, 1036));
          this.AddRoomDecoration(RoomDecoration.FromCode(33013, 22, 20, 0, 1036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32914, 568, 104, 15, 1036));
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

