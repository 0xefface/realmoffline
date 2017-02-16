using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1026 : Room
  {
        public Room1026()
            : base(1026, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 500, 296, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(32830, 576, 139, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 164, 192, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 92, 318, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 161, 191, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 143, 329, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 52, 322, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 57, 314, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 98, 313, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 464, 283, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 564, 140, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 173, 195, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 322, 103, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(33010, 567, 80, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 15, 105, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 102, 255, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 275, 256, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 449, 254, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 569, 250, 0, 1026));
          this.AddRoomDecoration(RoomDecoration.FromCode(146, 382, 105, 15, 1026));
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

