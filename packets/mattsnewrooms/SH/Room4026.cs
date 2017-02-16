using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4026 : Room
  {
        public Room4026()
            : base(4026, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 61, 197, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 598, 263, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 503, 103, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 21, 102, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 462, 118, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 239, 102, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 230, 158, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 234, 134, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 238, 102, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 62, 131, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 616, 251, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 578, 253, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 86, 186, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 245, 206, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 271, 277, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 89, 199, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 596, 265, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 570, 255, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 38, 120, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 63, 121, 0, 4026));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 131, 118, 0, 4026));
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

