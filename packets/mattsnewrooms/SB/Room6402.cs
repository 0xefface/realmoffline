using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6402 : Room
  {
        public Room6402()
            : base(6402, "Good Fortune Inn Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 99, 149, 50, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2165, 604, 121, 50, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 446, 112, 100, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 174, 109, 100, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 261, 205, 150, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 542, 116, 100, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 206, 229, 0, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 200, 269, 170, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 201, 299, 220, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 69, 114, 100, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 314, 299, 200, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 467, 230, 0, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 417, 234, 0, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 364, 262, 0, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 416, 292, 0, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 536, 236, 0, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 588, 243, 0, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 586, 282, 0, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 303, 227, 0, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 398, 275, 0, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 456, 262, 0, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 501, 262, 0, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 559, 276, 0, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 588, 109, 65506, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 366, 116, 30, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 491, 190, 65516, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 218, 335, 0, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 551, 139, 0, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2596, 515, 153, 20, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 386, 115, 60, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2018, 2, 164, 100, 6402));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 611, 120, 50, 6402));
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

