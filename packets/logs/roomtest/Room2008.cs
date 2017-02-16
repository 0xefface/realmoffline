using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2008 : Room
  {
        public Room2008()
            : base(2008, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32917, 523, 127, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32918, 327, 131, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 153, 133, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 86, 122, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 21, 202, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 25, 141, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(102, 411, 317, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 4, 321, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 141, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 108, 132, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 132, 132, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 156, 130, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 208, 127, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 232, 127, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 256, 126, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 280, 125, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 298, 130, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 322, 130, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 130, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 496, 124, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 520, 126, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 124, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 81, 118, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 104, 118, 0, 2008));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 655, 175, 0, 2008));
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

