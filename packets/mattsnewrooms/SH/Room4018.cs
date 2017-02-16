using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4018 : Room
  {
        public Room4018()
            : base(4018, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 609, 321, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 575, 260, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 84, 182, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 531, 275, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 91, 190, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(32944, 193, 104, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(32944, 234, 104, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 68, 115, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 479, 118, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 65533, 120, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 526, 127, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 201, 203, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(33000, 236, 102, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 241, 104, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 616, 124, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 238, 123, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 226, 161, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 229, 257, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 70, 187, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 603, 286, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 76, 193, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 44, 189, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 87, 188, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 126, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 538, 126, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 8, 119, 0, 4018));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 628, 124, 0, 4018));
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

