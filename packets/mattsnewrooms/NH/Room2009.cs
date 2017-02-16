using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2009 : Room
  {
        public Room2009()
            : base(2009, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 137, 128, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 337, 119, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 561, 138, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 9, 165, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 5, 166, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 465, 215, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 465, 219, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 115, 126, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 138, 127, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 161, 125, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 515, 137, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 538, 137, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 135, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 202, 116, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 118, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 320, 119, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 342, 119, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 364, 119, 0, 2009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 615, 118, 0, 2009));
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

