using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6314 : Room
  {
        public Room6314()
            : base(6314, "The Last Call Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 18, 156, 50, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 442, 11, 0, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 180, 9, 0, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 237, 51, 0, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 540, 115, 100, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 203, 244, 0, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 204, 100, 18, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 206, 110, 47, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 76, 56, 40, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 318, 80, 200, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 549, 178, 16, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 322, 209, 0, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 497, 173, 0, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 376, 116, 30, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 108, 239, 0, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 475, 296, 0, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2018, 11, 114, 50, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 361, 51, 0, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 616, 121, 50, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2041, 52, 180, 0, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2544, 62, 181, 16, 6314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 325, 97, 0, 6314));
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

