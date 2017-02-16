using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1375 : Room
{
public Room1375()
: base(1375, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 417, 124, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 299, 133, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 131, 120, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 524, 145, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 424, 211, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 46, 181, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 602, 261, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 274, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 44, 178, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 258, 252, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 143, 238, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 318, 251, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 398, 215, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 212, 258, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 449, 228, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 611, 275, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(327, 140, 0, 156, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(32991, 235, 259, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 155, 261, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 131, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 69, 132, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 12, 126, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 297, 139, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 334, 141, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 349, 138, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 370, 147, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 393, 147, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 415, 147, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 473, 139, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 507, 144, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 531, 144, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 547, 144, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 149, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 622, 144, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 87, 184, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 259, 185, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 469, 209, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 566, 210, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 32, 183, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 346, 201, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 318, 211, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 338, 219, 0, 1375));
this.AddRoomDecoration(RoomDecoration.FromCode(225, 355, 208, 0, 1375));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 0;
                case RoomExit.East:  return 0;
                case RoomExit.West:  return 0;
                default: return 0;
            }
        }
}
}
