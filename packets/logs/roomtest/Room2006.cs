using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2006 : Room
  {
        public Room2006()
            : base(2006, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32919, 324, 139, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 124, 136, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32918, 516, 122, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 420, 236, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 97, 319, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 93, 323, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 417, 236, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 227, 106, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 65443, 115, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 539, 109, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 319, 138, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 343, 138, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 367, 138, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 497, 122, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 520, 122, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 542, 122, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 136, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 134, 136, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 156, 136, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 211, 133, 0, 2006));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 235, 133, 0, 2006));
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

