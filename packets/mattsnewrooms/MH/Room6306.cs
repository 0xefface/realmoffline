using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6306 : Room
  {
        public Room6306()
            : base(6306, "Bewitchment's Best Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 321, 289, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 111, 180, 65506, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2020, 170, 28, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 243, 6, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 344, 49, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 328, 59, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2125, 332, 127, 90, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(34911, 463, 396, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(34916, 684, 415, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(34917, 684, 386, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(34921, 688, 195, 90, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2148, 43, 201, 40, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2162, 330, 105, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 130, 118, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2596, 497, 148, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 64, 142, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 35, 134, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2087, 556, 173, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2129, 335, 200, 60, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(34893, 330, 199, 35, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 330, 198, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2125, 332, 199, 3, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 211, 137, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 232, 153, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 426, 157, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 405, 141, 0, 6306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2086, 51, 168, 0, 6306));
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

