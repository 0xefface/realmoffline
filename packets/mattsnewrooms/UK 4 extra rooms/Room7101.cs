using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7101 : Room
  {
        public Room7101()
            : base(7101, "Marvelous Armory")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.SnowyDesert;
          this.BlockedRoomExits = BlockedExits.Up;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 135, 29, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2801, 87, 145, 29, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 276, 11, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 381, 37, 50, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(38912, 563, 127, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 610, 120, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2621, 699, 121, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 38, 66, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(35561, 102, 129, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 55, 65535, 65437, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 17, 198, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 93, 194, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 487, 202, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 167, 198, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 400, 187, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(38923, 589, 208, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 92, 178, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 215, 187, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(38913, 624, 69, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 352, 168, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(6144, 170, 75, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 630, 195, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 561, 200, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(6163, 6, 186, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(38931, 30, 64, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 113, 43, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 103, 25, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 190, 177, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 450, 151, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 450, 145, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2544, 207, 150, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(6006, 4, 6, 65490, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(38781, 26, 141, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 45, 22, 65455, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(6010, 558, 196, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(6006, 310, 290, 65490, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(38776, 546, 271, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(6007, 595, 200, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(182, 413, 303, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(181, 506, 270, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(32950, 593, 227, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(182, 644, 240, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(6068, 69, 36, 0, 7101));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 190, 216, 0, 7101));
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

