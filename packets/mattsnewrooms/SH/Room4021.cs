using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4021 : Room
  {
        public Room4021()
            : base(4021, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 102, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 103, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 424, 135, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 666, 131, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 121, 206, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 565, 319, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 603, 334, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 122, 212, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 567, 306, 6, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 45, 136, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 136, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 137, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 135, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 80, 136, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 147, 123, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 123, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 305, 134, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 328, 137, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 352, 138, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 376, 136, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 399, 136, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 423, 137, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 446, 135, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 469, 135, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 137, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 515, 137, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 539, 137, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 132, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 589, 132, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 613, 132, 0, 4021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 132, 0, 4021));
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

