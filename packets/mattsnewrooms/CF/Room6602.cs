using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6602 : Room
  {
        public Room6602()
            : base(6602, "Emerald Forest Inn Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 99, 149, 50, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2165, 607, 151, 50, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 446, 112, 100, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 174, 109, 100, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 261, 205, 150, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 542, 116, 100, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 206, 229, 0, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 200, 206, 108, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 198, 214, 136, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 69, 114, 100, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 314, 299, 200, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 303, 227, 0, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 588, 109, 65506, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 366, 116, 30, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 413, 190, 65516, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 214, 309, 0, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2018, 2, 164, 100, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 611, 120, 50, 6602));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 386, 115, 60, 6602));
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

