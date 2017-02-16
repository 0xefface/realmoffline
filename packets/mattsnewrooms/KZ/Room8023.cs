using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8023 : Room
  {
        public Room8023()
            : base(8023, "Stillwater Pub Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 17, 162, 50, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(3599, 492, 312, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 433, 15, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 531, 116, 100, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 155, 231, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 607, 118, 50, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 154, 302, 220, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 44, 118, 100, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 374, 61, 65502, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 467, 230, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 417, 234, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 364, 262, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 416, 292, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 536, 236, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 588, 243, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 586, 282, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 65527, 54, 65437, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 402, 192, 65516, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 398, 275, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 456, 262, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 501, 262, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(59529, 559, 276, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 588, 109, 65506, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 240, 57, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 147, 14, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 339, 58, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 626, 223, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 475, 297, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2599, 119, 289, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 154, 152, 50, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2126, 156, 231, 63, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 369, 167, 80, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 413, 162, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 332, 162, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 252, 162, 0, 8023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2080, 30, 172, 0, 8023));
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

