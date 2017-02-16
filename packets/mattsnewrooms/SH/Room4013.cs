using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4013 : Room
  {
        public Room4013()
            : base(4013, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32875, 551, 314, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 169, 248, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 150, 250, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 155, 103, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 515, 103, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 739, 105, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 44, 115, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 230, 120, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 127, 118, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 575, 118, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 240, 165, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(33003, 333, 231, 50, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 480, 217, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 638, 215, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(195, 16, 45, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(195, 199, 48, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(197, 301, 102, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 132, 165, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 50, 162, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 532, 337, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 219, 121, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 243, 120, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 117, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 107, 117, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 131, 117, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 114, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 114, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 113, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(195, 530, 46, 0, 4013));
          this.AddRoomDecoration(RoomDecoration.FromCode(197, 458, 50, 0, 4013));
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

