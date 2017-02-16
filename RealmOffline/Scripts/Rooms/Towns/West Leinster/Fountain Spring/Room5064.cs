using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5064 : Room
{
public Room5064()
: base(5064, "Fountain Spring")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x39, 0x16, 0x00, 0xDE, 0x01, 0x06, 0x01, 0x00, 0x00, 0x16, 0x80, 0x1C, 0x02, 0xF2, 0x00, 0x00, 0x00, 0x15, 0x00, 0x5A, 0x02, 0x15, 0x01, 0x00, 0x00, 0x15, 0x00, 0x7E, 0x01, 0xF8, 0x00, 0x00, 0x00, 0x16, 0x80, 0x92, 0x01, 0x1D, 0x01, 0x00, 0x00, 0x2D, 0x00, 0x0C, 0x02, 0xF5, 0x00, 0x00, 0x00, 0x16, 0x00, 0x7D, 0x00, 0x03, 0x01, 0x00, 0x00, 0x16, 0x00, 0x75, 0x00, 0x1E, 0x01, 0x00, 0x00, 0x16, 0x80, 0xFA, 0x00, 0x20, 0x01, 0x00, 0x00, 0x15, 0x80, 0x81, 0x00, 0xEF, 0x00, 0x00, 0x00, 0xE2, 0x00, 0x14, 0x01, 0x24, 0x01, 0x00, 0x00, 0xE9, 0x00, 0xE9, 0x00, 0xCD, 0x00, 0x00, 0x00, 0x16, 0x00, 0x18, 0x02, 0xD8, 0x00, 0x00, 0x00, 0x16, 0x80, 0x7D, 0x01, 0xD7, 0x00, 0x00, 0x00, 0x16, 0x80, 0x22, 0x02, 0xBF, 0x00, 0x00, 0x00, 0x16, 0x80, 0x60, 0x01, 0xC2, 0x00, 0x00, 0x00, 0x16, 0x80, 0x1A, 0x02, 0xA7, 0x00, 0x00, 0x00, 0x2D, 0x00, 0x6E, 0x02, 0x3A, 0x01, 0x00, 0x00, 0x2D, 0x00, 0x48, 0x02, 0x0C, 0x01, 0x00, 0x00, 0x2D, 0x00, 0xC9, 0x01, 0xE8, 0x00, 0x00, 0x00, 0x16, 0x00, 0x5E, 0x00, 0x0B, 0x00, 0x00, 0x00, 0x16, 0x80, 0x0F, 0x02, 0x03, 0x00, 0x00, 0x00, 0x16, 0x00, 0x18, 0x02, 0x1A, 0x00, 0x00, 0x00, 0x16, 0x80, 0x46, 0x00, 0x25, 0x00, 0x00, 0x00, 0x16, 0x00, 0x2E, 0x00, 0x3B, 0x00, 0x00, 0x00, 0x16, 0x80, 0x41, 0x02, 0x2E, 0x00, 0x00, 0x00, 0x2B, 0x00, 0xD8, 0x01, 0x39, 0x00, 0x00, 0x00, 0x2B, 0x00, 0x0C, 0x02, 0x49, 0x00, 0x00, 0x00, 0x2B, 0x00, 0x3D, 0x02, 0x55, 0x00, 0x00, 0x00, 0x2B, 0x00, 0x6E, 0x02, 0x53, 0x00, 0x00, 0x00, 0x2B, 0x00, 0x10, 0x00, 0x5E, 0x00, 0x00, 0x00, 0x2B, 0x00, 0x41, 0x00, 0x53, 0x00, 0x00, 0x00, 0x2B, 0x00, 0x74, 0x00, 0x50, 0x00, 0x00, 0x00, 0x2B, 0x00, 0x9E, 0x00, 0x3A, 0x00, 0x00, 0x00, 0xDF, 0x1E, 0x5D, 0x00, 0x2E, 0x00, 0x00, 0x00, 0xDF, 0x1E, 0x21, 0x02, 0x2E, 0x00, 0x00, 0x00, 0x9D, 0x8A, 0x7F, 0x01, 0x33, 0x01, 0x00, 0x00, 0x9D, 0x8A, 0xA4, 0x01, 0x3D, 0x01, 0x00, 0x00, 0x9D, 0x8A, 0xA3, 0x01, 0x4E, 0x01, 0x00, 0x00, 0x3C, 0x00, 0x19, 0x00, 0x2A, 0x01, 0x00, 0x00, 0x87, 0x0B, 0x25, 0x00, 0x3E, 0x01, 0x00, 0x00, 0x3C, 0x00, 0x5B, 0x00, 0x14, 0x01, 0x00, 0x00, 0xCC, 0x00, 0x6E, 0x01, 0x25, 0x01, 0x00, 0x00, 0xCC, 0x00, 0xC2, 0x01, 0x24, 0x01, 0x00, 0x00, 0xC8, 0x00, 0x90, 0x01, 0x1D, 0x01, 0x00, 0x00, 0xDF, 0x1E, 0x5A, 0x00, 0x5A, 0x01, 0x00, 0x00, 0xDE, 0x1E, 0x49, 0x02, 0xDD, 0x00, 0x00, 0x00, 0xDE, 0x1E, 0xF0, 0x01, 0x5C, 0x01, 0x00, 0x00, 0x03, 0x00, 0x54, 0x01, 0x20, 0x01, 0x00, 0x00, 0x03, 0x00, 0x65, 0x01, 0x28, 0x01, 0x00, 0x00, 0x03, 0x00, 0x6C, 0x01, 0x34, 0x01, 0x00, 0x00, 0x03, 0x00, 0x69, 0x01, 0x11, 0x01, 0x00, 0x00, 0x03, 0x00, 0xC5, 0x01, 0x1A, 0x01, 0x00, 0x00, 0x03, 0x00, 0xAF, 0x01, 0x1B, 0x01, 0x00, 0x00, 0x03, 0x00, 0xED, 0x01, 0x2C, 0x01, 0x00, 0x00, 0x03, 0x00, 0xDB, 0x01, 0x21, 0x01, 0x00, 0x00, 0x03, 0x00, 0xFA, 0x01, 0x36, 0x01, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x09, 0x00, 0x01, 0x16, 0x00, 0x16, 0x4D, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xC8, 0x13, 0x9E, 0x01, 0x26, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x10, 0x01, 0x17, 0x4D, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xC8, 0x13, 0xAF, 0x01, 0x33, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x10, 0x01, 0x18, 0x4D, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xC8, 0x13, 0xD3, 0x01, 0x3F, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x10, 0x01, 0x19, 0x4D, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xC8, 0x13, 0xC7, 0x01, 0x38, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x1A, 0x4D, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xC8, 0x13, 0x2E, 0x02, 0x2B, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x1B, 0x4D, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xC8, 0x13, 0x04, 0x02, 0x10, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x1C, 0x4D, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xC8, 0x13, 0xD3, 0x01, 0xFE, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x10, 0x01, 0x1D, 0x4D, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xC8, 0x13, 0xE4, 0x01, 0x4D, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x10, 0x01, 0x1E, 0x4D, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xC8, 0x13, 0xE2, 0x01, 0x3D, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x27, 0x58, 0x6E, 0x6F };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}