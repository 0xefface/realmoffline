using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6200 : Room
  {
        public Room6200()
            : base(6200, "The Thresher's Roost Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 442, 105, 100, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 176, 40, 35, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 241, 97, 50, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 538, 110, 100, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 213, 222, 0, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 233, 251, 170, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 238, 280, 220, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 70, 109, 100, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 324, 150, 47, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 65527, 54, 65437, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 380, 212, 0, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2599, 501, 291, 0, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 612, 115, 50, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 144, 155, 50, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 169, 156, 170, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2104, 315, 191, 65516, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 381, 138, 50, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(34989, 67, 205, 0, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2018, 24, 204, 150, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 365, 148, 100, 6200));
          this.AddRoomDecoration(RoomDecoration.FromCode(2599, 187, 289, 0, 6200));
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

