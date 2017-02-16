using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1008 : Room
  {
        public Room1008()
            : base(1008, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 169, 107, 0, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 244, 211, 0, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 358, 181, 0, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 257, 180, 65511, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32830, 367, 183, 65516, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 47, 37, 0, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 240, 103, 0, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 562, 111, 0, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32908, 628, 97, 0, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 455, 202, 120, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 339, 132, 0, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 530, 178, 120, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 131, 214, 120, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 199, 196, 120, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 464, 208, 120, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 273, 236, 120, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 355, 215, 120, 1008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 390, 215, 120, 1008));
          this.AllowCasting = False;
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

