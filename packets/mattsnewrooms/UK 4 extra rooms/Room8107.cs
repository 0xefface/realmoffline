using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8107 : Room
  {
        public Room8107()
            : base(8107, "Farthing Inn Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2080, 49, 156, 0, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 500, 10, 0, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 176, 10, 0, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 231, 51, 0, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 597, 115, 100, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 335, 9, 0, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 188, 235, 0, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 422, 57, 65497, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 414, 57, 65516, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 71, 14, 0, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 517, 188, 65516, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 439, 52, 0, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2018, 3, 63, 0, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 16, 140, 20, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2600, 446, 305, 0, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 425, 86, 0, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 323, 104, 0, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 197, 144, 0, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 50, 167, 17, 8107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 176, 158, 17, 8107));
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

