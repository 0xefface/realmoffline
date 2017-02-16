using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room6908 : Room
{
public Room6908()
: base(6908, "The Fashion Statement Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
byte[] roomDecItems = { 0x18, 0x46, 0x08, 0x05, 0x01, 0x81, 0x01, 0x00, 0x00, 0x74, 0x08, 0x5D, 0x00, 0x71, 0x00, 0x00, 0x00, 0x37, 0x08, 0xD4, 0x01, 0x57, 0x01, 0x00, 0x00, 0x35, 0x08, 0xD0, 0x00, 0xDF, 0x00, 0x00, 0x00, 0x35, 0x08, 0x38, 0x00, 0xEE, 0x00, 0x00, 0x00, 0xE4, 0x07, 0xAA, 0x00, 0x1C, 0x00, 0x00, 0x00, 0xEC, 0x07, 0xF3, 0x00, 0x06, 0x00, 0x00, 0x00, 0xED, 0x07, 0x5A, 0x01, 0x31, 0x00, 0x00, 0x00, 0xEC, 0x07, 0xA5, 0x01, 0x08, 0x00, 0x00, 0x00, 0xD8, 0x07, 0xE4, 0x01, 0x28, 0x00, 0x00, 0x00, 0x58, 0x08, 0x01, 0x00, 0xEF, 0x00, 0x2D, 0x00, 0x58, 0x88, 0xBE, 0x02, 0x7A, 0x01, 0x00, 0x00, 0x46, 0x08, 0xD5, 0x01, 0x58, 0x01, 0x3F, 0x00, 0x58, 0x08, 0x96, 0x00, 0xE0, 0x00, 0x2D, 0x00, 0x22, 0x0A, 0xCF, 0x00, 0x7B, 0x00, 0x00, 0x00, 0x22, 0x0A, 0x97, 0x01, 0x7B, 0x00, 0x00, 0x00, 0x22, 0x08, 0xE3, 0x00, 0x69, 0x00, 0xEC, 0xFF, 0x22, 0x08, 0xAB, 0x01, 0x69, 0x00, 0xEC, 0xFF, 0x40, 0x08, 0x44, 0x01, 0x54, 0x00, 0x00, 0x00, 0x3D, 0x08, 0x48, 0x01, 0xCD, 0x00, 0x00, 0x00, 0x46, 0x88, 0x4B, 0x01, 0xCD, 0x00, 0x40, 0x00, 0x46, 0x88, 0x4A, 0x01, 0xCE, 0x00, 0x02, 0x00, 0x46, 0x08, 0x4A, 0x01, 0xCE, 0x00, 0x21, 0x00, 0x75, 0x08, 0x61, 0x02, 0x75, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xD9, 0x02, 0x55, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xFC, 0x1A, 0x15, 0x02, 0xD1, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 };

this.AddRoomItemsByteBlock(roomItems);
byte[] npcs = { 0x00, 0x01, 0x19, 0x0B, 0x56, 0x48, 0x01, 0x00, 0x00, 0xFF, 0x00, 0x0C, 0x08, 0x64, 0x64, 0x01, 0x00, 0x00, 0x0A, 0x00, 0x53, 0x69, 0x72, 0x6B, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0x30, 0x09, 0x00, 0x00, 0x30, 0x09, 0x00, 0x00, 0x01, 0xFC, 0x1A, 0x98, 0x00, 0xD1, 0x00, 0x00, 0x00, 0x08, 0x00, 0x01, 0xF7, 0x04, 0x57, 0x48, 0x01, 0x00, 0x35, 0x00, 0x01, 0x04, 0x00, 0x43, 0x6F, 0x77, 0x6C, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x6B, 0x04, 0x58, 0x48, 0x01, 0x00, 0x49, 0x00, 0x01, 0x05, 0x00, 0x54, 0x75, 0x6E, 0x69, 0x63, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x8A, 0x04, 0x59, 0x48, 0x01, 0x00, 0x35, 0x00, 0x01, 0x04, 0x00, 0x48, 0x6F, 0x73, 0x65, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x0E, 0x05, 0x5A, 0x48, 0x01, 0x00, 0x3A, 0x00, 0x01, 0x04, 0x00, 0x42, 0x65, 0x6C, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAA, 0x04, 0x5B, 0x48, 0x01, 0x00, 0x3A, 0x00, 0x01, 0x0A, 0x00, 0x48, 0x69, 0x67, 0x68, 0x20, 0x42, 0x6F, 0x6F, 0x74, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0x5E, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x06, 0x0B, 0x06, 0x06, 0x05, 0x00, 0x03, 0x06, 0x00, 0x01, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddNpcsByteBlock(npcs);
base.ApplyRoomLayout();
}
}
}