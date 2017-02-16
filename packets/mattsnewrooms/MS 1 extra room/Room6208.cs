using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6208 : Room
  {
        public Room6208()
            : base(6208, "Dog's Breath Inn Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 464, 15, 0, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2016, 145, 5, 35, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 201, 5, 20, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 401, 3, 20, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 288, 47, 20, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 550, 155, 0, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 303, 91, 0, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 338, 127, 0, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 200, 126, 0, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2555, 372, 128, 17, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 96, 92, 0, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 158, 280, 0, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 268, 282, 0, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 305, 163, 65516, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 327, 169, 65526, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 602, 162, 17, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2555, 234, 127, 17, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2125, 308, 168, 20, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 285, 168, 65526, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 169, 182, 0, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2244, 115, 192, 0, 6208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 599, 316, 0, 6208));
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

