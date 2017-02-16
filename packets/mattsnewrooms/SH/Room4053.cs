using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4053 : Room
  {
        public Room4053()
            : base(4053, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 515, 108, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 40, 108, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 587, 319, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 112, 184, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 142, 204, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 142, 208, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 588, 320, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 112, 188, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32943, 309, 104, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 287, 264, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 284, 276, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 218, 120, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 526, 118, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 198, 112, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 115, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 464, 119, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 286, 275, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 24, 116, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 48, 116, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 115, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 189, 120, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 212, 120, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 235, 120, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 251, 120, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 443, 119, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 464, 118, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 488, 119, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 117, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 533, 119, 0, 4053));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 555, 119, 0, 4053));
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

