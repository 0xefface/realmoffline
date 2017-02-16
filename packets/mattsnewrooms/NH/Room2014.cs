using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2014 : Room
  {
        public Room2014()
            : base(2014, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 420, 236, 0, 2014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 97, 319, 0, 2014));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 93, 328, 0, 2014));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 417, 241, 0, 2014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 392, 235, 0, 2014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 578, 144, 0, 2014));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 581, 149, 0, 2014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 92, 113, 0, 2014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 591, 129, 0, 2014));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 440, 111, 0, 2014));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 224, 105, 0, 2014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 546, 127, 0, 2014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 570, 128, 0, 2014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 588, 128, 0, 2014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 620, 128, 0, 2014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 635, 128, 0, 2014));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 117, 0, 2014));
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

