using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7110 : Room
  {
        public Room7110()
            : base(7110, "Usk Gatekeeper")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.SnowyDesert;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(6137, 161, 91, 150, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 364, 84, 60, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(38920, 605, 165, 50, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 391, 137, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(6002, 232, 62, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(6002, 129, 204, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(38923, 322, 82, 65462, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(6072, 275, 57, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(6018, 313, 79, 65468, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 42, 237, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 466, 41, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(2720, 422, 188, 65531, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 549, 200, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(6014, 79, 162, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 446, 184, 131, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 56, 214, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 714, 336, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(2535, 717, 176, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 613, 201, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 609, 23, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(6145, 519, 188, 136, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(6145, 407, 197, 164, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(35483, 638, 141, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(38930, 8, 224, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 29, 227, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(6163, 280, 74, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(38923, 605, 214, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 544, 159, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(2556, 561, 133, 0, 7110));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 463, 216, 0, 7110));
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

