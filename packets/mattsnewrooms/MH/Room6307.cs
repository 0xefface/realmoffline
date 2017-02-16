using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6307 : Room
  {
        public Room6307()
            : base(6307, "Blade and Shield Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 280, 23, 0, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 380, 15, 0, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(34989, 72, 182, 0, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 92, 23, 0, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 15, 97, 50, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 494, 24, 0, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 563, 171, 65526, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 372, 80, 0, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(34888, 569, 182, 60, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 278, 266, 65521, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 457, 80, 0, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 185, 23, 0, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 569, 180, 60, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 421, 171, 65526, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2120, 422, 180, 30, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 607, 24, 0, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 207, 130, 65527, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2121, 569, 182, 3, 6307));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 170, 137, 4, 6307));
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

