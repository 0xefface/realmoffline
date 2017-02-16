using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8310 : Room
  {
        public Room8310()
            : base(8310, "Sundries World Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 464, 15, 0, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2016, 145, 5, 35, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 201, 5, 20, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 401, 3, 20, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 288, 47, 20, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 603, 141, 0, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 303, 91, 0, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 380, 113, 0, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 229, 112, 0, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2131, 259, 183, 0, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 96, 92, 0, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 158, 280, 0, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 268, 282, 0, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 305, 163, 65516, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 330, 180, 0, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(34928, 305, 167, 20, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 618, 225, 0, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 637, 261, 0, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 595, 302, 0, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 169, 182, 0, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2244, 115, 192, 0, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 208, 116, 6, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 359, 116, 6, 8310));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 567, 142, 6, 8310));
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

