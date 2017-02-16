using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4055 : Room
  {
        public Room4055()
            : base(4055, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 108, 109, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 103, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 616, 317, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 38, 256, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 43, 250, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 36, 248, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 373, 203, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 315, 196, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 343, 209, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 310, 200, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 387, 202, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 48, 124, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 398, 123, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 482, 124, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 108, 127, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 290, 202, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 343, 209, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 83, 127, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 107, 127, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 130, 127, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 412, 123, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 436, 124, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 459, 124, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 481, 125, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 504, 125, 0, 4055));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 518, 124, 0, 4055));
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

