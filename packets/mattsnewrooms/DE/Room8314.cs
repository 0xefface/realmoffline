using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8314 : Room
  {
        public Room8314()
            : base(8314, "Daemon Delight Tavern Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2165, 596, 118, 50, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 494, 13, 0, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 175, 11, 0, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 269, 54, 0, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 592, 117, 100, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 181, 245, 0, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 224, 76, 0, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 223, 77, 20, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 71, 15, 0, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 431, 281, 200, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(34989, 53, 106, 65437, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 131, 210, 0, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 138, 130, 50, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 169, 156, 170, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2104, 270, 236, 0, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 412, 143, 50, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2018, 12, 62, 0, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 385, 54, 0, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 148, 305, 0, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 498, 305, 0, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2558, 331, 150, 16, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 297, 149, 0, 8314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 291, 161, 0, 8314));
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

