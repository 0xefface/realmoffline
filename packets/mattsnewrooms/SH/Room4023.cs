using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4023 : Room
  {
        public Room4023()
            : base(4023, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 520, 113, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 73, 111, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 113, 244, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 165, 201, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 213, 197, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 142, 202, 8, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 114, 245, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 192, 201, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 527, 122, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 432, 137, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 606, 133, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 65479, 102, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32944, 259, 103, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32944, 460, 103, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 431, 102, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32923, 618, 134, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 406, 136, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 425, 136, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 449, 135, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 494, 121, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 518, 122, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 541, 121, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 134, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 603, 134, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 134, 0, 4023));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 563, 121, 0, 4023));
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

