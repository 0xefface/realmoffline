using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6612 : Room
  {
        public Room6612()
            : base(6612, "Vlador's Tavern Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 101, 144, 50, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 497, 39, 30, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 176, 38, 30, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 284, 50, 0, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 593, 114, 100, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 214, 244, 0, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 181, 264, 170, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 185, 294, 220, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 71, 113, 100, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 522, 292, 200, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 524, 205, 0, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2106, 118, 233, 0, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2106, 317, 235, 0, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 463, 307, 0, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 148, 309, 0, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2018, 65521, 164, 100, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 381, 51, 0, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(34896, 121, 233, 64, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 91, 113, 0, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2080, 16, 172, 0, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 477, 152, 0, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 374, 152, 0, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 270, 150, 0, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 19, 180, 14, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 249, 162, 14, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 353, 163, 14, 6612));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 456, 163, 14, 6612));
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

