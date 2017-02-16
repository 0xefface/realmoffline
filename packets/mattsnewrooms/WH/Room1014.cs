using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1014 : Room
  {
        public Room1014()
            : base(1014, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 285, 279, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(32830, 301, 297, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 53, 152, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 519, 320, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 42, 152, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 566, 332, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 475, 322, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 473, 320, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 572, 321, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 166, 218, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 360, 217, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 549, 215, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 39, 239, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 244, 220, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 211, 238, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 29, 220, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 395, 236, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 408, 220, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 586, 236, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 593, 216, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 268, 297, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 117, 220, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 499, 106, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 27, 79, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 162, 114, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 30, 150, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(32910, 189, 111, 0, 1014));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 65532, 219, 0, 1014));
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

