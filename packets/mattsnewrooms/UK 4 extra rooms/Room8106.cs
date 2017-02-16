using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8106 : Room
  {
        public Room8106()
            : base(8106, "The Usk Boutique Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 467, 16, 0, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2016, 145, 5, 35, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 201, 5, 20, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 407, 4, 20, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 288, 47, 20, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2087, 626, 161, 0, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 303, 91, 0, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 196, 123, 0, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 411, 123, 0, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2131, 253, 184, 0, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 96, 92, 0, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 158, 280, 0, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 267, 282, 0, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 302, 163, 65516, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 327, 165, 65522, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(34928, 301, 167, 20, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 618, 225, 0, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 637, 261, 0, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 595, 302, 0, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 169, 182, 0, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2244, 115, 192, 0, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 566, 135, 0, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 175, 107, 0, 8106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 390, 107, 0, 8106));
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

