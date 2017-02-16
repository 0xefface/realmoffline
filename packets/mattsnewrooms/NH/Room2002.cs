using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2002 : Room
  {
        public Room2002()
            : base(2002, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32917, 292, 133, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 104, 132, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(32918, 488, 135, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 222, 198, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 436, 328, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 222, 196, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 619, 139, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 226, 199, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 80, 133, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 104, 133, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 127, 133, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 572, 137, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 596, 137, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 614, 135, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 134, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 481, 134, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 459, 134, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 269, 131, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 292, 131, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 314, 131, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 370, 131, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 393, 130, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 413, 129, 0, 2002));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 433, 127, 0, 2002));
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

