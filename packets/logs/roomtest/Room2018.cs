using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2018 : Room
  {
        public Room2018()
            : base(2018, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32944, 440, 103, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 36, 102, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 0, 123, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 509, 115, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 437, 249, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 79, 318, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 189, 144, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 190, 145, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 437, 252, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 287, 2, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 561, 126, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 280, 107, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 124, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 123, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 58, 123, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 87, 123, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 108, 121, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 129, 119, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 149, 118, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 125, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 125, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 556, 125, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 124, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 124, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 622, 123, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 375, 105, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 370, 107, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 337, 227, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 355, 173, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 358, 236, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 370, 174, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 366, 119, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 370, 132, 0, 2018));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 378, 133, 0, 2018));
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

