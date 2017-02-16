using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6902 : Room
  {
        public Room6902()
            : base(6902, "Swiper's Seminary Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2599, 183, 266, 0, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2339, 490, 17, 0, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2339, 684, 107, 65436, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2340, 334, 4, 0, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2340, 224, 4, 0, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2340, 114, 4, 0, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2340, 334, 62, 65436, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2340, 224, 62, 65436, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2340, 114, 62, 65436, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2339, 490, 127, 65486, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2133, 210, 271, 50, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 211, 111, 0, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 211, 72, 65436, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 211, 150, 100, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2339, 684, 47, 0, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 149, 270, 45, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2339, 587, 32, 0, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(34989, 52, 164, 0, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2339, 587, 142, 65486, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2310, 387, 178, 10, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2310, 121, 68, 65436, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2310, 640, 152, 65486, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2338, 65532, 137, 0, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2385, 336, 62, 65436, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2383, 432, 166, 65526, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2383, 432, 162, 65526, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2383, 506, 172, 65526, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2383, 507, 177, 65526, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(34921, 129, 273, 40, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2129, 211, 73, 65466, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 170, 116, 40, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 227, 116, 40, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2130, 234, 156, 110, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(34899, 269, 120, 40, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(34903, 206, 118, 10, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2131, 159, 159, 110, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2135, 217, 78, 65446, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(2106, 52, 266, 0, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 549, 202, 0, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 453, 196, 0, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 336, 179, 0, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 334, 170, 0, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 436, 183, 0, 6902));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 774, 225, 0, 6902));
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

