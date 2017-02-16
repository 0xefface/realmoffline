using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8301 : Room
  {
        public Room8301()
            : base(8301, "Broken Jug Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 76, 164, 50, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 433, 15, 0, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 531, 116, 100, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 156, 230, 0, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 367, 68, 65504, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 157, 85, 4, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 44, 118, 100, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 268, 63, 65486, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 65527, 54, 65437, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 402, 192, 65516, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 588, 109, 65506, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 240, 57, 0, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 147, 14, 0, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 339, 58, 0, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 626, 223, 0, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 475, 297, 0, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2599, 124, 289, 0, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 156, 79, 65513, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2126, 156, 231, 63, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 365, 182, 80, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 607, 118, 50, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 10, 163, 0, 8301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2086, 65533, 189, 0, 8301));
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

