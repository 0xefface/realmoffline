using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8311 : Room
  {
        public Room8311()
            : base(8311, "Birger's Barbery Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 160, 162, 0, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 466, 151, 0, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 358, 18, 20, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 455, 16, 20, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 165, 6, 0, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 504, 17, 0, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 262, 17, 20, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 89, 31, 0, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 192, 75, 0, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 107, 88, 0, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 65533, 46, 0, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 422, 242, 0, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2142, 262, 354, 65496, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(34910, 361, 398, 0, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 339, 104, 0, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2596, 250, 105, 0, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 240, 242, 0, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2165, 480, 71, 0, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 599, 185, 15, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 422, 392, 0, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2080, 337, 90, 65516, 8311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 285, 91, 65516, 8311));
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

