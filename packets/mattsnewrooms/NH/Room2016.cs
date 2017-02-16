using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2016 : Room
  {
        public Room2016()
            : base(2016, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 78, 114, 0, 2016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 120, 0, 2016));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 166, 189, 0, 2016));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 268, 105, 0, 2016));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 169, 187, 0, 2016));
          this.AddRoomDecoration(RoomDecoration.FromCode(245, 298, 33, 0, 2016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 80, 128, 0, 2016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 141, 187, 0, 2016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 165, 188, 0, 2016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 189, 187, 0, 2016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 126, 0, 2016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 58, 128, 0, 2016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 127, 0, 2016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 106, 126, 0, 2016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 129, 126, 0, 2016));
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

