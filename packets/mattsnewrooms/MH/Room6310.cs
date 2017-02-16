using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6310 : Room
  {
        public Room6310()
            : base(6310, "Volzer's Weapons Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 280, 23, 0, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 381, 15, 0, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 580, 171, 0, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 93, 1, 65514, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 11, 2, 65490, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 494, 24, 0, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 427, 179, 0, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2041, 32, 149, 0, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(34888, 431, 180, 58, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2544, 268, 145, 16, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 116, 89, 0, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 13, 45, 65472, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 533, 280, 0, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 52, 269, 0, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2120, 310, 236, 58, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2544, 44, 152, 16, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 185, 23, 0, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2121, 540, 281, 34, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2121, 59, 270, 34, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 304, 235, 0, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2041, 256, 142, 0, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 373, 68, 0, 6310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 490, 67, 0, 6310));
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

