using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4009 : Room
  {
        public Room4009()
            : base(4009, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 10, 165, 0, 4009));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 2, 166, 0, 4009));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 464, 214, 0, 4009));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 465, 220, 0, 4009));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 108, 107, 0, 4009));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 470, 107, 0, 4009));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 532, 106, 0, 4009));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 591, 119, 0, 4009));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 56, 116, 0, 4009));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 629, 119, 0, 4009));
          this.AddRoomDecoration(RoomDecoration.FromCode(194, 23, 87, 0, 4009));
          this.AddRoomDecoration(RoomDecoration.FromCode(195, 605, 53, 0, 4009));
          this.AddRoomDecoration(RoomDecoration.FromCode(197, 516, 51, 0, 4009));
          this.AddRoomDecoration(RoomDecoration.FromCode(32965, 368, 102, 0, 4009));
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

