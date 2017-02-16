using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2052 : Room
  {
        public Room2052()
            : base(2052, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 283, 102, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 410, 103, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 586, 105, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 82, 102, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 65496, 104, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 100, 116, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 677, 128, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 423, 208, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 431, 209, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(33012, 65524, 46, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 295, 230, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 280, 102, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 293, 168, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 317, 107, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 279, 165, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 299, 218, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 281, 116, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 276, 128, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 556, 127, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 580, 129, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 604, 129, 0, 2052));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 129, 0, 2052));
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

