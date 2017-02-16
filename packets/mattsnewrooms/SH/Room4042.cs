using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4042 : Room
  {
        public Room4042()
            : base(4042, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 305, 103, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 114, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 181, 122, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 407, 232, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(32992, 382, 247, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 65, 132, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 600, 129, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 149, 132, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 413, 231, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 317, 223, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 289, 192, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 437, 189, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 580, 184, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 163, 212, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 291, 210, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 198, 197, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 42, 212, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 447, 204, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 587, 199, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 451, 188, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 601, 185, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 24, 193, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 539, 132, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 371, 225, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 134, 196, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 35, 193, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 354, 235, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(32953, 401, 250, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 34, 130, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 131, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 83, 131, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 95, 131, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 126, 131, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 150, 131, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 174, 131, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 237, 122, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 261, 122, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 285, 122, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 213, 122, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 190, 122, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 512, 131, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 535, 130, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 558, 130, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 582, 128, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 602, 129, 0, 4042));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 624, 128, 0, 4042));
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

