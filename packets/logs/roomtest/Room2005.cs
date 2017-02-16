using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2005 : Room
  {
        public Room2005()
            : base(2005, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 289, 133, 0, 2005));
          this.AddRoomDecoration(RoomDecoration.FromCode(32919, 572, 137, 0, 2005));
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 473, 115, 0, 2005));
          this.AddRoomDecoration(RoomDecoration.FromCode(32918, 98, 122, 0, 2005));
          this.AddRoomDecoration(RoomDecoration.FromCode(32875, 533, 314, 0, 2005));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 169, 248, 0, 2005));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 152, 248, 0, 2005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 537, 356, 0, 2005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 242, 131, 0, 2005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 265, 132, 0, 2005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 285, 129, 0, 2005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 577, 135, 0, 2005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 600, 135, 0, 2005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 617, 134, 0, 2005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 356, 114, 0, 2005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 96, 123, 0, 2005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 120, 124, 0, 2005));
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

