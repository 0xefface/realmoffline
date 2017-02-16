using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4054 : Room
  {
        public Room4054()
            : base(4054, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 125, 111, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 398, 274, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 573, 144, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 27, 119, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 405, 283, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 172, 184, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(32943, 345, 110, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 212, 182, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 196, 178, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 538, 137, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 74, 120, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 186, 185, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 219, 122, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 551, 145, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 576, 145, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 590, 144, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 555, 140, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 582, 139, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 65535, 124, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 515, 136, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 533, 136, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 123, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 23, 119, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 47, 121, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 120, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 91, 119, 0, 4054));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 121, 0, 4054));
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

