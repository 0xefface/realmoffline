using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7107 : Room
  {
        public Room7107()
            : base(7107, "The Farthing Inn")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.SnowyDesert;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 318, 41, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 138, 53, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2508, 503, 46, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(38771, 583, 239, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 176, 59, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 654, 64, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(6144, 225, 89, 3, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 504, 244, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(38912, 605, 86, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 90, 80, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2621, 741, 82, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(6005, 479, 273, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(38772, 527, 278, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(38783, 632, 249, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 175, 237, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 110, 186, 20, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 165, 195, 20, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(38923, 126, 225, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 136, 70, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 149, 189, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(6151, 621, 336, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(6150, 426, 210, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 94, 180, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(38932, 594, 236, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 435, 124, 65498, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 420, 115, 65475, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 475, 185, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 491, 191, 20, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 531, 193, 0, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 548, 199, 20, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2795, 353, 125, 65516, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2794, 368, 121, 65534, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2710, 356, 166, 90, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(6018, 416, 120, 65469, 7107));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 149, 70, 0, 7107));
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

