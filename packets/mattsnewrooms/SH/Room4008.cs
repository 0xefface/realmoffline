using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4008 : Room
  {
        public Room4008()
            : base(4008, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Up;
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 6, 199, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(102, 411, 317, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 14, 322, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 70, 108, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 385, 108, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 612, 108, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 592, 117, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 323, 118, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 499, 126, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(194, 596, 91, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(195, 318, 54, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 475, 125, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 499, 125, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 523, 125, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 287, 117, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 311, 118, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 334, 118, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 358, 118, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 125, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 562, 116, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 587, 115, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 610, 116, 0, 4008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 630, 116, 0, 4008));
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

