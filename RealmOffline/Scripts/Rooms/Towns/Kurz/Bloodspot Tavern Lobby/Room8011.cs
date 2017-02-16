using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
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
byte[] roomDecItems = { 0x15, 0x45, 0x08, 0xF3, 0x00, 0x3C, 0x00, 0xBB, 0xFF, 0xEC, 0x07, 0xF4, 0x01, 0x0A, 0x00, 0x00, 0x00, 0xEC, 0x07, 0xB0, 0x00, 0x0A, 0x00, 0x00, 0x00, 0x4F, 0x08, 0x1F, 0x01, 0x80, 0x00, 0x96, 0x00, 0xED, 0x07, 0xE7, 0x00, 0x33, 0x00, 0x00, 0x00, 0xD5, 0x07, 0x55, 0x02, 0x73, 0x00, 0x64, 0x00, 0xEC, 0x07, 0x4F, 0x01, 0x09, 0x00, 0x00, 0x00, 0x37, 0x08, 0xC3, 0x00, 0xF4, 0x00, 0x00, 0x00, 0x40, 0x08, 0x4F, 0x01, 0x36, 0x00, 0xC3, 0xFF, 0x50, 0x08, 0x50, 0x01, 0x98, 0x00, 0x37, 0x00, 0xE1, 0x07, 0x47, 0x00, 0x0E, 0x00, 0x00, 0x00, 0xC1, 0x08, 0x12, 0x02, 0xD2, 0x00, 0x00, 0x00, 0xED, 0x07, 0xB7, 0x01, 0x34, 0x00, 0x00, 0x00, 0xE2, 0x07, 0x03, 0x00, 0x3F, 0x00, 0x00, 0x00, 0x74, 0x08, 0x62, 0x00, 0x8C, 0x00, 0x14, 0x00, 0x28, 0x0A, 0xBC, 0x01, 0x30, 0x01, 0x00, 0x00, 0x22, 0x08, 0xFC, 0x01, 0x95, 0x00, 0x00, 0x00, 0x22, 0x08, 0xBF, 0x01, 0x95, 0x00, 0x00, 0x00, 0x22, 0x08, 0xA1, 0x00, 0x95, 0x00, 0x00, 0x00, 0x22, 0x08, 0xDF, 0x00, 0x95, 0x00, 0x00, 0x00, 0x20, 0x08, 0x1D, 0x00, 0xA4, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x09, 0x00, 0x01, 0xE0, 0x02, 0x34, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x4B, 0x1F, 0x3A, 0x01, 0x25, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x35, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x4B, 0x1F, 0x54, 0x01, 0x13, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x36, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x4B, 0x1F, 0x31, 0x02, 0x20, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x37, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x4B, 0x1F, 0x16, 0x02, 0x12, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x38, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x4B, 0x1F, 0x9F, 0x01, 0x0E, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x39, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x4B, 0x1F, 0x75, 0x01, 0x0D, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xD9, 0x02, 0x3A, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x4B, 0x1F, 0x53, 0x02, 0xD4, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x3B, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x4B, 0x1F, 0xCB, 0x01, 0x0E, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x3C, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x4B, 0x1F, 0xF3, 0x01, 0x0F, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01, 0x28, 0x0B, 0x3D, 0x4A, 0x01, 0x00, 0x00, 0xFF, 0x00, 0x0C, 0x08, 0x64, 0x64, 0x01 };

this.AddRoomItemsByteBlock(roomItems);
byte[] npcs = { 0x00, 0x01, 0x0A, 0x00, 0x4E, 0x61, 0x6E, 0x7A, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0xA0, 0x08, 0x00, 0x00, 0xA0, 0x08, 0x00, 0x00, 0x01, 0x4B, 0x1F, 0xC0, 0x00, 0xE3, 0x00, 0x02, 0x00, 0x05, 0x00, 0x01, 0xF8, 0x04, 0x3E, 0x4A, 0x01, 0x00, 0x5E, 0x00, 0x01, 0x04, 0x00, 0x43, 0x6F, 0x77, 0x6C, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x69, 0x04, 0x3F, 0x4A, 0x01, 0x00, 0x63, 0x00, 0x01, 0x07, 0x00, 0x44, 0x6F, 0x75, 0x62, 0x6C, 0x65, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x8D, 0x04, 0x40, 0x4A, 0x01, 0x00, 0x5E, 0x00, 0x01, 0x0A, 0x00, 0x4C, 0x6F, 0x6E, 0x67, 0x20, 0x53, 0x6B, 0x69, 0x72, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAC, 0x04, 0x41, 0x4A, 0x01, 0x00, 0x49, 0x00, 0x01, 0x09, 0x00, 0x4C, 0x6F, 0x77, 0x20, 0x42, 0x6F, 0x6F, 0x74, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0x42, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x01, 0x06, 0x00, 0x05, 0x0B, 0x02, 0x02, 0x03, 0x0A, 0x01, 0x02, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 };

this.AddNpcsByteBlock(npcs);
base.ApplyRoomLayout();
}
}
}
