using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8002 : Room
  {
        public Room8002()
            : base(8002, "Pleasure's Fabric Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 511, 343, 65, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 108, 102, 0, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2116, 390, 123, 0, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 290, 147, 50, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 327, 207, 0, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 154, 205, 0, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2020, 170, 28, 0, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 243, 8, 0, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 346, 49, 0, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2136, 80, 206, 49, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 52, 474, 75, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 329, 290, 0, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 507, 342, 0, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 150, 342, 0, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 152, 342, 65, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 332, 208, 65, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 227, 110, 65516, 8002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 436, 112, 65516, 8002));
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

