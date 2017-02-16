using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room6600 : Room
{
public Room6600()
: base(6600, "Necromancer's Wares Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
byte[] roomDecItems = { 0x1E, 0x46, 0x08, 0x05, 0x01, 0x81, 0x01, 0x00, 0x00, 0x37, 0x08, 0x3E, 0x01, 0x48, 0x01, 0x00, 0x00, 0xE4, 0x07, 0xAA, 0x00, 0x1B, 0x00, 0x00, 0x00, 0xEC, 0x07, 0xF3, 0x00, 0x07, 0x00, 0x00, 0x00, 0xED, 0x07, 0x52, 0x01, 0x31, 0x00, 0x00, 0x00, 0xEC, 0x07, 0xA6, 0x01, 0x08, 0x00, 0x00, 0x00, 0xD8, 0x07, 0xE4, 0x01, 0x28, 0x00, 0x00, 0x00, 0x58, 0x88, 0xBE, 0x02, 0x7A, 0x01, 0x00, 0x00, 0x3F, 0x08, 0x1C, 0x02, 0x60, 0x00, 0x00, 0x00, 0x40, 0x08, 0x49, 0x01, 0x74, 0x00, 0x00, 0x00, 0x73, 0x08, 0xE1, 0x00, 0x31, 0x00, 0x00, 0x00, 0x73, 0x08, 0xB2, 0x01, 0x31, 0x00, 0x00, 0x00, 0x38, 0x08, 0x20, 0x00, 0xE5, 0x00, 0x00, 0x00, 0x4D, 0x08, 0x43, 0x01, 0x49, 0x01, 0x41, 0x00, 0xFB, 0x07, 0xC3, 0x00, 0x95, 0x00, 0x00, 0x00, 0xFB, 0x07, 0x86, 0x01, 0x91, 0x00, 0x00, 0x00, 0x36, 0x08, 0x19, 0x02, 0xCE, 0x00, 0x00, 0x00, 0x4C, 0x08, 0x4C, 0x01, 0x75, 0x00, 0x14, 0x00, 0x5E, 0x08, 0xDB, 0xFF, 0xE6, 0x00, 0x32, 0x00, 0x62, 0x88, 0x34, 0x02, 0x61, 0x00, 0x11, 0x00, 0x72, 0x08, 0x69, 0x02, 0x7E, 0x00, 0x00, 0x00, 0x71, 0x08, 0x1C, 0x00, 0x79, 0x00, 0x00, 0x00, 0x51, 0x08, 0x68, 0x01, 0x40, 0x00, 0x74, 0xFF, 0x52, 0x88, 0xFA, 0x00, 0x37, 0x00, 0x6F, 0xFF, 0x69, 0x08, 0x15, 0x02, 0xCF, 0x00, 0x2D, 0x00, 0x01, 0x08, 0xBD, 0x00, 0xA0, 0x00, 0x00, 0x00, 0x01, 0x08, 0x80, 0x01, 0xA1, 0x00, 0x00, 0x00, 0xFE, 0x09, 0xE5, 0x00, 0x96, 0x00, 0x10, 0x00, 0xFE, 0x09, 0xA8, 0x01, 0x94, 0x00, 0x0E, 0x00, 0xDE, 0x1E, 0x36, 0x01, 0xCE, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xDC, 0x02, 0x07, 0x49, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xC8, 0x19, 0x88, 0x00, 0xCE, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 };

this.AddRoomItemsByteBlock(roomItems);
byte[] npcs = { 0x00, 0x01, 0x17, 0x0B, 0x08, 0x49, 0x01, 0x00, 0x00, 0xFF, 0x00, 0x0C, 0x08, 0x64, 0x64, 0x01, 0x00, 0x00, 0x0B, 0x00, 0x41, 0x76, 0x65, 0x72, 0x79, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x01, 0xC8, 0x19, 0x3C, 0x01, 0x2D, 0x01, 0x02, 0x00, 0x05, 0x00, 0x01, 0x69, 0x04, 0x09, 0x49, 0x01, 0x00, 0x30, 0x00, 0x01, 0x07, 0x00, 0x44, 0x6F, 0x75, 0x62, 0x6C, 0x65, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x8C, 0x04, 0x0A, 0x49, 0x01, 0x00, 0x35, 0x00, 0x01, 0x0A, 0x00, 0x4C, 0x6F, 0x6E, 0x67, 0x20, 0x53, 0x6B, 0x69, 0x72, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x0E, 0x05, 0x0B, 0x49, 0x01, 0x00, 0x58, 0x00, 0x01, 0x04, 0x00, 0x42, 0x65, 0x6C, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAC, 0x04, 0x0C, 0x49, 0x01, 0x00, 0x53, 0x00, 0x01, 0x09, 0x00, 0x4C, 0x6F, 0x77, 0x20, 0x42, 0x6F, 0x6F, 0x74, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0x0D, 0x49, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x08, 0x06, 0x02, 0x02, 0x01, 0x03, 0xFF, 0x02, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0xC4 };

this.AddNpcsByteBlock(npcs);
base.ApplyRoomLayout();
}
}
}
