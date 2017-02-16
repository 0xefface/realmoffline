using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8101 : Room
  {
        public Room8101()
            : base(8101, "Marvelous Armory Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 280, 23, 0, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 381, 15, 0, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 580, 171, 0, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 89, 23, 0, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 15, 97, 50, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 494, 24, 0, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 427, 179, 0, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(34887, 427, 180, 2, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2544, 45, 154, 17, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2119, 434, 180, 31, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 116, 89, 0, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 10, 99, 65521, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 533, 280, 0, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 52, 269, 0, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2544, 262, 146, 17, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(34887, 530, 281, 2, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2119, 65, 270, 2, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2121, 540, 281, 34, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2121, 59, 270, 34, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 304, 235, 0, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2041, 251, 144, 0, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 373, 68, 0, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 490, 67, 0, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 185, 23, 0, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2041, 33, 152, 0, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2047, 29, 165, 0, 8101));
          this.AddRoomDecoration(RoomDecoration.FromCode(2047, 246, 157, 0, 8101));
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

