using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2021 : Room
  {
        public Room2021()
            : base(2021, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 102, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 139, 103, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 424, 135, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 666, 131, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 42, 319, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 408, 220, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 603, 326, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 402, 226, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(33012, 25, 67, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 410, 137, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 303, 135, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 325, 136, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 348, 136, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 372, 135, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 436, 137, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 460, 136, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 483, 135, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 507, 137, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 136, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 565, 132, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 585, 132, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 612, 132, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 166, 122, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 143, 122, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 119, 122, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 630, 132, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 95, 121, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 72, 122, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 50, 123, 0, 2021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 27, 122, 0, 2021));
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

