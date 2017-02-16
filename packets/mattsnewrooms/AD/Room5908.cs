using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5908 : Room
  {
        public Room5908()
            : base(5908, "The Fashion Statement")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 157, 59, 0, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 182, 55, 0, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 164, 68, 0, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 109, 247, 0, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 334, 130, 0, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 176, 16, 0, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 403, 145, 0, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(35516, 433, 90, 0, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 36, 165, 65517, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 25, 165, 0, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2691, 9, 280, 200, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(35369, 107, 71, 0, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 410, 231, 0, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2508, 6, 40, 0, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(35369, 349, 165, 0, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 65491, 215, 0, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 368, 245, 0, 5908));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 340, 245, 0, 5908));
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

