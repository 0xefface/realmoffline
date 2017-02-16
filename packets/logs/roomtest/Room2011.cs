using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2011 : Room
  {
        public Room2011()
            : base(2011, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 281, 133, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 461, 132, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 635, 121, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32917, 66, 125, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32874, 312, 316, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 30, 123, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 53, 125, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 75, 124, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 97, 122, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 265, 132, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 288, 132, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 247, 132, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 365, 129, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 387, 130, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 410, 131, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 434, 131, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 458, 130, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 610, 118, 0, 2011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 632, 121, 0, 2011));
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

