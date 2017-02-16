using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7300 : Room
  {
        public Room7300()
            : base(7300, "Drune")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 35, 136, 0, 7300));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 137, 130, 0, 7300));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 363, 103, 0, 7300));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 171, 258, 0, 7300));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 472, 274, 0, 7300));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 25, 287, 0, 7300));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 599, 302, 0, 7300));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 417, 286, 0, 7300));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 154, 275, 0, 7300));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 613, 244, 0, 7300));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 375, 248, 0, 7300));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 247, 288, 0, 7300));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 288, 283, 0, 7300));
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

