using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5111 : Room
{
public Room5111()
: base(5111, "Shining Forge")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x11, 0x2E, 0x0A, 0xA1, 0x00, 0x5B, 0x00, 0x96, 0x00, 0xD8, 0x09, 0xD4, 0x01, 0x57, 0x00, 0x00, 0x00, 0x35, 0x0A, 0x5F, 0x01, 0x8E, 0x00, 0x00, 0x00, 0xB9, 0x0A, 0x67, 0x02, 0x45, 0x00, 0xD9, 0xFF, 0x98, 0x0A, 0x35, 0x02, 0x29, 0x00, 0xD1, 0xFF, 0x89, 0x0B, 0x7E, 0x02, 0xBF, 0x00, 0x00, 0x00, 0xC5, 0x09, 0x47, 0x01, 0x69, 0x00, 0x00, 0x00, 0xC6, 0x09, 0x06, 0x01, 0x6E, 0x00, 0x00, 0x00, 0xC5, 0x09, 0xB2, 0x00, 0x52, 0x00, 0x00, 0x00, 0x42, 0x0A, 0xD7, 0x00, 0x87, 0x00, 0x00, 0x00, 0x35, 0x0A, 0xDB, 0x00, 0xAA, 0x00, 0x32, 0x00, 0x45, 0x0A, 0xDE, 0x00, 0x88, 0x00, 0x00, 0x00, 0x1B, 0x0A, 0xE4, 0x00, 0xF3, 0x00, 0x00, 0x00, 0x15, 0x0A, 0xCD, 0x00, 0xEB, 0x00, 0x00, 0x00, 0x6F, 0x00, 0x6E, 0x02, 0xBF, 0x00, 0x00, 0x00, 0x16, 0x00, 0x26, 0x02, 0x17, 0x01, 0x00, 0x00, 0x15, 0x00, 0x57, 0x00, 0x11, 0x01, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xD9, 0x02, 0x93, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xF7, 0x13, 0xD7, 0x01, 0x07, 0x01, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}