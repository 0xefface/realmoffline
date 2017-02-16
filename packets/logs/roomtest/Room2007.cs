using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2007 : Room
  {
        public Room2007()
            : base(2007, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 107, 137, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 574, 134, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 355, 134, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 159, 135, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 46, 286, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 191, 206, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 189, 208, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 47, 287, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 188, 207, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 646, 325, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 642, 222, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 107, 136, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 130, 135, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 333, 135, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 356, 134, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 134, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 442, 130, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 466, 130, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 551, 133, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 133, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 596, 132, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 86, 135, 0, 2007));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 153, 134, 0, 2007));
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

