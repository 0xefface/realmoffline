using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4041 : Room
  {
        public Room4041()
            : base(4041, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 609, 321, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 555, 259, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 86, 181, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32992, 617, 283, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 71, 182, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 248, 103, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 36, 102, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 0, 123, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 479, 118, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 6, 126, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 592, 111, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 350, 125, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 216, 182, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 371, 181, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 515, 181, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 275, 103, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 218, 197, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 72, 199, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 356, 197, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 464, 195, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 395, 182, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 150, 184, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 38, 184, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 136, 135, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 468, 129, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 404, 130, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 167, 124, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 266, 145, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 568, 178, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 71, 183, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 88, 182, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 555, 282, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 610, 319, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32953, 512, 294, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32953, 550, 317, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 568, 300, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 120, 133, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 141, 134, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 165, 134, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 178, 122, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 30, 126, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 10, 126, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 337, 123, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 358, 123, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 373, 129, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 395, 129, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 419, 129, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 443, 129, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 466, 129, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 490, 129, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 502, 128, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 289, 229, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 279, 182, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 317, 237, 0, 4041));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 287, 183, 0, 4041));
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

