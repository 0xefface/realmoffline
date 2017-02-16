using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2037 : Room
  {
        public Room2037()
            : base(2037, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 440, 102, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 683, 104, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 586, 105, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 145, 103, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 65496, 104, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(35510, 100, 116, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 677, 128, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 470, 214, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(33012, 598, 28, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 281, 192, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 299, 198, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 586, 188, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 71, 191, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 216, 192, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 281, 226, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 197, 129, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 470, 212, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 368, 187, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 521, 184, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 283, 218, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 145, 128, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 169, 129, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 192, 129, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 215, 127, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 238, 129, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 259, 126, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 556, 129, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 129, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 604, 129, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 128, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 58, 200, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 218, 201, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 317, 198, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 412, 195, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 570, 194, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 292, 208, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 307, 227, 0, 2037));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 305, 211, 0, 2037));
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

