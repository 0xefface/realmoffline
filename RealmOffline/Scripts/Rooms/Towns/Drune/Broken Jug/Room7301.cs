using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room7301 : Room
{
public Room7301()
: base(7301, "Broken Jug")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x30, 0xCC, 0x09, 0x7B, 0x00, 0x4D, 0x00, 0x00, 0x00, 0xD1, 0x09, 0x12, 0x01, 0x5F, 0x00, 0x00, 0x00, 0xD2, 0x09, 0x51, 0x01, 0x60, 0x00, 0x00, 0x00, 0xD2, 0x09, 0xA8, 0x01, 0x52, 0x00, 0x00, 0x00, 0xD1, 0x09, 0xDD, 0x01, 0x3E, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x65, 0x01, 0xF3, 0x00, 0x00, 0x00, 0x14, 0x0A, 0xBD, 0x01, 0xB8, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x14, 0x02, 0x03, 0x00, 0x36, 0xFF, 0x15, 0x0A, 0x2C, 0x00, 0xBE, 0x00, 0x00, 0x00, 0x15, 0x0A, 0x2D, 0x00, 0x4E, 0x00, 0x0A, 0x00, 0x14, 0x0A, 0x4C, 0x01, 0xCB, 0x00, 0x00, 0x00, 0x14, 0x0A, 0x85, 0x01, 0xC1, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x36, 0x01, 0x22, 0x01, 0x75, 0xFF, 0x20, 0x0A, 0x58, 0x01, 0xCD, 0x00, 0x0F, 0x00, 0x20, 0x0A, 0x90, 0x01, 0xC4, 0x00, 0x0F, 0x00, 0x20, 0x0A, 0xC8, 0x01, 0xBB, 0x00, 0x0F, 0x00, 0x21, 0x0A, 0x3D, 0x00, 0xC5, 0x00, 0x15, 0x00, 0x21, 0x0A, 0x3E, 0x00, 0x52, 0x00, 0x1D, 0x00, 0x29, 0x8A, 0x98, 0x01, 0x9B, 0x00, 0x4B, 0x00, 0x31, 0x00, 0x28, 0x01, 0xF2, 0x00, 0x00, 0x00, 0x2D, 0x00, 0x0F, 0x00, 0xED, 0x00, 0x00, 0x00, 0x98, 0x0A, 0x1A, 0x00, 0xF3, 0x00, 0x00, 0x00, 0x87, 0x0B, 0x53, 0x01, 0xEB, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0xE2, 0x00, 0x05, 0x01, 0x00, 0x00, 0x9D, 0x0A, 0x24, 0x00, 0x00, 0x01, 0x00, 0x00, 0x8C, 0x0B, 0x2E, 0x01, 0xFE, 0x00, 0x00, 0x00, 0x29, 0x8A, 0x57, 0x01, 0xA7, 0x00, 0x4B, 0x00, 0xC6, 0x0A, 0xDF, 0x00, 0x9A, 0x00, 0x00, 0x00, 0x29, 0x8A, 0xE2, 0x00, 0xB9, 0x00, 0x4B, 0x00, 0x2E, 0x00, 0x0B, 0x02, 0xE6, 0x00, 0x00, 0x00, 0x2E, 0x80, 0x3F, 0x01, 0xF5, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0xAC, 0x01, 0xF1, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0xFC, 0x01, 0xEA, 0x00, 0x00, 0x00, 0xBF, 0x0A, 0xC4, 0x00, 0xD1, 0x00, 0x00, 0x00, 0xC0, 0x0A, 0xC7, 0x00, 0x04, 0x01, 0x00, 0x00, 0xC1, 0x0A, 0xCB, 0x00, 0x8B, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0xC8, 0x00, 0x9C, 0x00, 0x00, 0x00, 0xC3, 0x0A, 0xE1, 0x00, 0xD0, 0x00, 0x00, 0x00, 0x19, 0x80, 0x2A, 0x01, 0x35, 0x01, 0x00, 0x00, 0x2E, 0x80, 0x06, 0x02, 0xB6, 0x00, 0x00, 0x00, 0x1A, 0x00, 0x3C, 0x02, 0x08, 0x00, 0x00, 0x00, 0x1A, 0x80, 0x29, 0x02, 0x05, 0x00, 0x00, 0x00, 0x19, 0x00, 0x4E, 0x02, 0x3C, 0x00, 0x00, 0x00, 0x18, 0x80, 0x8B, 0x02, 0xA9, 0x00, 0x00, 0x00, 0xF8, 0x0A, 0x7B, 0x00, 0x74, 0x00, 0x00, 0x00, 0xEE, 0x0A, 0x70, 0x00, 0x75, 0x00, 0x00, 0x00, 0x18, 0x80, 0x53, 0x00, 0x08, 0x01, 0x00, 0x00, 0x8C, 0x8B, 0xFC, 0xFF, 0x0D, 0x01, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xDB, 0x02, 0x59, 0x49, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x85, 0x1C, 0x8D, 0x00, 0xFD, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
