using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2027 : Room
  {
        public Room2027()
            : base(2027, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 308, 103, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 527, 114, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 500, 256, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 473, 262, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 500, 250, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(241, 427, 1, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 437, 200, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 360, 228, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 94, 127, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 102, 121, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 580, 194, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 230, 125, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 206, 126, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 129, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 160, 129, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 136, 128, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 112, 127, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 89, 127, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 67, 128, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 44, 128, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 20, 128, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 6, 128, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 457, 207, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 564, 204, 0, 2027));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 384, 235, 0, 2027));
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

