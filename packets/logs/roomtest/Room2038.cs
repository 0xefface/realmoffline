using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2038 : Room
  {
        public Room2038()
            : base(2038, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 28, 108, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 315, 105, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 537, 233, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 82, 191, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 557, 122, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 203, 227, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 186, 220, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 169, 225, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 581, 121, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 72, 199, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 155, 34, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 532, 243, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 310, 240, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 171, 104, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(35511, 544, 124, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 172, 109, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 532, 123, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 179, 231, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 330, 234, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 172, 212, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 485, 121, 0, 2038));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 123, 0, 2038));
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

