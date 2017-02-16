using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6203 : Room
  {
        public Room6203()
            : base(6203, "The Bend Sinister Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 94, 155, 50, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 454, 6, 0, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 177, 7, 0, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 249, 49, 0, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 551, 111, 100, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 228, 247, 0, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 233, 206, 68, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 71, 111, 100, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 317, 99, 65535, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 331, 180, 65516, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2105, 138, 215, 65516, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 231, 203, 0, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2106, 330, 247, 0, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 150, 140, 40, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 389, 116, 20, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 363, 49, 0, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2018, 12, 112, 50, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2599, 474, 287, 0, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 617, 113, 50, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 192, 153, 0, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2047, 4, 182, 0, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2041, 9, 170, 0, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 198, 140, 0, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 20, 171, 17, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2555, 232, 141, 17, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 358, 154, 0, 6203));
          this.AddRoomDecoration(RoomDecoration.FromCode(2555, 398, 143, 17, 6203));
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

