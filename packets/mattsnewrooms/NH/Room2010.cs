using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2010 : Room
  {
        public Room2010()
            : base(2010, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32917, 292, 133, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 106, 131, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(32918, 488, 135, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 222, 195, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 438, 313, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 222, 198, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 619, 139, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 264, 131, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 288, 132, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 312, 132, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 138, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 593, 138, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 616, 137, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 85, 131, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 108, 131, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 132, 131, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 463, 136, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 487, 136, 0, 2010));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 136, 0, 2010));
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

