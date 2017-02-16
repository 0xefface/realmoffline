using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8104 : Room
  {
        public Room8104()
            : base(8104, "Tub Tavern Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 101, 144, 50, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 497, 39, 30, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 176, 38, 30, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 284, 50, 0, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 593, 114, 100, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 214, 244, 0, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 181, 264, 170, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 185, 294, 220, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 71, 113, 100, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 521, 111, 15, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 524, 205, 0, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2106, 118, 233, 0, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2106, 317, 235, 0, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 463, 309, 0, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 148, 311, 0, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2018, 65521, 164, 100, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 381, 51, 0, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(34896, 121, 233, 64, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 91, 113, 0, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2080, 15, 164, 0, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 462, 150, 0, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 375, 150, 0, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 291, 151, 0, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 270, 165, 17, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 356, 164, 17, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 441, 164, 17, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 17, 176, 17, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2086, 4, 184, 0, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 291, 164, 0, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 377, 164, 0, 8104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 462, 163, 0, 8104));
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

