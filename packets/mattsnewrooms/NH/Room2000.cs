using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2000 : Room
  {
        public Room2000()
            : base(2000, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 565, 124, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 343, 130, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 145, 138, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 114, 127, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 298, 243, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 201, 139, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(102, 65522, 317, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 554, 225, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 294, 248, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 551, 214, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 45, 190, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 46, 138, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 70, 138, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 138, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 117, 137, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 140, 137, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 164, 139, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 188, 138, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 211, 139, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 234, 139, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 110, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 324, 129, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 129, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 52, 138, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 299, 130, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 599, 120, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 576, 123, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 528, 121, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 71, 194, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 128, 210, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 53, 180, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 564, 228, 0, 2000));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 312, 239, 0, 2000));
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

