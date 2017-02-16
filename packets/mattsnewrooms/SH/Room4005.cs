using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4005 : Room
  {
        public Room4005()
            : base(4005, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 136, 252, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 162, 107, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 605, 121, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 546, 106, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 160, 249, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 590, 155, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 535, 319, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 595, 158, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 42, 118, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 191, 116, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(194, 26, 90, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 616, 121, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(32963, 307, 102, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 9, 117, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 117, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 116, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 72, 117, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 203, 115, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 117, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 121, 0, 4005));
          this.AddRoomDecoration(RoomDecoration.FromCode(195, 348, 102, 0, 4005));
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

