using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6305 : Room
  {
        public Room6305()
            : base(6305, "Eldest Inn Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 76, 164, 50, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 433, 15, 0, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 531, 116, 100, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 156, 230, 0, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 373, 100, 65534, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 154, 302, 220, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 44, 118, 100, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 268, 100, 65523, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 65527, 54, 65437, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 402, 192, 65516, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 588, 109, 65506, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 240, 57, 0, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 147, 14, 0, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 339, 58, 0, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 653, 223, 0, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 475, 297, 0, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2599, 128, 290, 0, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 154, 152, 50, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2126, 156, 231, 63, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 365, 182, 80, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 607, 118, 50, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 9, 168, 12, 6305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2080, 7, 162, 0, 6305));
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

