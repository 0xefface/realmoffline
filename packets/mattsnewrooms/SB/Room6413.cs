using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6413 : Room
  {
        public Room6413()
            : base(6413, "The White Rabbit Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 94, 148, 50, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 323, 94, 100, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 175, 115, 100, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 235, 203, 150, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 538, 114, 100, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 442, 93, 50, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 236, 215, 65516, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 189, 252, 170, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 185, 283, 220, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2087, 661, 188, 0, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 69, 3, 0, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 290, 287, 200, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 418, 182, 0, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 336, 188, 0, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2596, 602, 183, 20, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2086, 5, 178, 0, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2105, 136, 185, 65496, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 398, 80, 50, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2018, 0, 54, 0, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2599, 511, 286, 0, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(34914, 147, 213, 40, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(34913, 162, 204, 35, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 624, 121, 50, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2599, 155, 296, 0, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 18, 152, 0, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 168, 250, 0, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(40672, 87, 240, 0, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 170, 238, 0, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 278, 238, 0, 6413));
          this.AddRoomDecoration(RoomDecoration.FromCode(7904, 278, 247, 0, 6413));
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

