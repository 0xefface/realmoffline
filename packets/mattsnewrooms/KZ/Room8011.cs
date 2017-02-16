using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8011 : Room
  {
        public Room8011()
            : base(8011, "Bloodspot Tavern Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 243, 60, 65467, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 500, 10, 0, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 176, 10, 0, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 231, 51, 0, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 597, 115, 100, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 335, 9, 0, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 195, 244, 0, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 335, 54, 65475, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 336, 152, 55, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 71, 14, 0, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 530, 210, 0, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 439, 52, 0, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2018, 3, 63, 0, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 98, 140, 20, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2600, 444, 304, 0, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 508, 149, 0, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 447, 149, 0, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 161, 149, 0, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 223, 149, 0, 8011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2080, 29, 164, 0, 8011));
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

