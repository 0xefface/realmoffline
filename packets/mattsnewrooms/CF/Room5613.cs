using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5613 : Room
  {
        public Room5613()
            : base(5613, "Commerce Corner")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.Down;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 229, 35, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 327, 50, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 251, 53, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 465, 32, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 562, 55, 50, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 223, 186, 65506, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 319, 229, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 274, 231, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 168, 173, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 615, 196, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 163, 190, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 389, 221, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 635, 203, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 480, 75, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 329, 239, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 492, 149, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 341, 172, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 621, 152, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 475, 176, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 341, 166, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2733, 617, 199, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(35381, 759, 175, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 431, 207, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 206, 221, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 381, 59, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2614, 296, 61, 15, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 125, 34, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 621, 146, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 254, 151, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 254, 157, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 468, 199, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 323, 231, 0, 5613));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 390, 241, 0, 5613));
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

