using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6900 : Room
  {
        public Room6900()
            : base(6900, "The Pig and Kettle Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 48, 160, 6, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 500, 10, 0, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 176, 10, 0, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 231, 51, 0, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 597, 115, 100, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 335, 9, 0, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 188, 235, 0, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 418, 268, 170, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 423, 297, 220, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 71, 14, 0, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 517, 188, 65516, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 439, 52, 0, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2018, 3, 63, 0, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 16, 140, 20, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2600, 446, 305, 0, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 425, 86, 0, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 323, 104, 0, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 178, 153, 6, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2080, 47, 159, 0, 6900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 199, 150, 0, 6900));
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

