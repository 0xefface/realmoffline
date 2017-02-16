using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2013 : Room
  {
        public Room2013()
            : base(2013, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(107, 137, 314, 0, 2013));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 486, 248, 0, 2013));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 492, 249, 0, 2013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 198, 118, 0, 2013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65507, 127, 0, 2013));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 115, 0, 2013));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 335, 103, 0, 2013));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 384, 228, 0, 2013));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 367, 103, 0, 2013));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 372, 125, 0, 2013));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 361, 169, 0, 2013));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 135, 344, 0, 2013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 6, 128, 0, 2013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 26, 126, 0, 2013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 584, 117, 0, 2013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 607, 117, 0, 2013));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 117, 0, 2013));
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

