using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room7016 : Room
{
public Room7016()
: base(7016, "Kurz Trading Post")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x23, 0xCC, 0x09, 0x7B, 0x00, 0x4A, 0x00, 0x00, 0x00, 0xD1, 0x09, 0x12, 0x01, 0x5F, 0x00, 0x00, 0x00, 0xD2, 0x09, 0x31, 0x01, 0x63, 0x00, 0x00, 0x00, 0xD2, 0x09, 0x62, 0x01, 0x5C, 0x00, 0x00, 0x00, 0xD1, 0x09, 0x97, 0x01, 0x49, 0x00, 0x00, 0x00, 0x9E, 0x0A, 0x0B, 0x00, 0xE5, 0x00, 0x00, 0x00, 0x31, 0x00, 0x7D, 0x02, 0x59, 0x01, 0x00, 0x00, 0x2D, 0x00, 0xBC, 0x01, 0xF8, 0x00, 0x00, 0x00, 0x98, 0x0A, 0x07, 0x00, 0xEF, 0x00, 0x00, 0x00, 0x87, 0x0B, 0xDA, 0x01, 0x8B, 0x00, 0x00, 0x00, 0x87, 0x0B, 0x50, 0x02, 0x94, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x0D, 0x00, 0xF7, 0x00, 0x00, 0x00, 0xE5, 0x1E, 0xF5, 0x00, 0x11, 0x01, 0x00, 0x00, 0xE5, 0x1E, 0xBB, 0x01, 0x00, 0x01, 0x00, 0x00, 0x2E, 0x00, 0x19, 0x02, 0x2F, 0x01, 0x00, 0x00, 0x2E, 0x80, 0x6F, 0x02, 0x6B, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x62, 0x02, 0xA6, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x7E, 0x01, 0x00, 0x01, 0x00, 0x00, 0x8C, 0x0B, 0x25, 0x00, 0x4C, 0x00, 0x75, 0xFF, 0x8C, 0x0B, 0x36, 0x01, 0x22, 0x01, 0x75, 0xFF, 0x8C, 0x0B, 0x00, 0x00, 0xBC, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0xC0, 0x01, 0xFA, 0x00, 0x00, 0x00, 0x35, 0x8A, 0xE5, 0x00, 0x6C, 0x00, 0x00, 0x00, 0xF3, 0x09, 0xF6, 0x00, 0xE9, 0x00, 0x00, 0x00, 0xF3, 0x09, 0x47, 0x01, 0xDC, 0x00, 0x00, 0x00, 0xF4, 0x09, 0x5F, 0x00, 0xC8, 0x00, 0x00, 0x00, 0xF4, 0x09, 0x60, 0x00, 0x4E, 0x00, 0x0D, 0x00, 0xF9, 0x09, 0x07, 0x01, 0xCE, 0x00, 0x00, 0x00, 0xF9, 0x09, 0x58, 0x01, 0xC1, 0x00, 0x00, 0x00, 0xFA, 0x09, 0x5F, 0x00, 0xC2, 0x00, 0x00, 0x00, 0xFA, 0x09, 0x60, 0x00, 0x4E, 0x00, 0x13, 0x00, 0x35, 0x8A, 0x51, 0x01, 0x6C, 0x00, 0x10, 0x00, 0x16, 0x80, 0x94, 0x01, 0x5F, 0x00, 0x3E, 0xFF, 0x8C, 0x0B, 0xFD, 0x00, 0x08, 0x01, 0x00, 0x00, 0x15, 0x80, 0x31, 0x02, 0x1C, 0x01, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xD9, 0x02, 0x08, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x68, 0x1B, 0xAA, 0x00, 0x04, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
