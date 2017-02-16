using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room6610 : Room
{
public Room6610()
: base(6610, "Treachery Weapons Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
byte[] roomDecItems = { 0x1B, 0xE9, 0x07, 0xB7, 0x00, 0x02, 0x00, 0x00, 0x00, 0xE9, 0x07, 0x85, 0x01, 0x10, 0x00, 0x00, 0x00, 0xAD, 0x88, 0x31, 0x00, 0xAC, 0x00, 0x00, 0x00, 0xDD, 0x07, 0x51, 0x00, 0x08, 0x00, 0x00, 0x00, 0xEA, 0x07, 0xDD, 0x01, 0x19, 0x00, 0x00, 0x00, 0x76, 0x08, 0xDA, 0x01, 0x4D, 0x00, 0x00, 0x00, 0x3D, 0x08, 0xAD, 0x01, 0xB7, 0x00, 0x00, 0x00, 0x47, 0x08, 0xB1, 0x01, 0xB8, 0x00, 0x3F, 0x00, 0x48, 0x08, 0xAC, 0x01, 0xB7, 0x00, 0x00, 0x00, 0x3D, 0x08, 0x8D, 0x00, 0x23, 0x01, 0x00, 0x00, 0x3D, 0x08, 0x17, 0x01, 0x23, 0x01, 0x00, 0x00, 0x47, 0x08, 0x8E, 0x00, 0x24, 0x01, 0x05, 0x00, 0x48, 0x88, 0x1B, 0x01, 0x24, 0x01, 0x3C, 0x00, 0x49, 0x08, 0x8C, 0x00, 0x24, 0x01, 0x22, 0x00, 0x49, 0x08, 0x21, 0x01, 0x24, 0x01, 0x04, 0x00, 0x3C, 0x08, 0x57, 0x02, 0xB6, 0x00, 0x00, 0x00, 0xD1, 0x07, 0x1F, 0x01, 0x07, 0x00, 0x00, 0x00, 0xD1, 0x07, 0x4F, 0x02, 0x29, 0x00, 0x14, 0x00, 0x5B, 0x88, 0x8C, 0x02, 0xB7, 0x00, 0xF1, 0xFF, 0x59, 0x88, 0x8A, 0x02, 0xB7, 0x00, 0x0D, 0x00, 0x21, 0x08, 0x6B, 0x02, 0x61, 0x00, 0xEC, 0xFF, 0x22, 0x08, 0x81, 0x01, 0x54, 0x00, 0xEC, 0xFF, 0x24, 0x0A, 0x47, 0x02, 0x6F, 0x00, 0x00, 0x00, 0x25, 0x0A, 0x6C, 0x01, 0x65, 0x00, 0x00, 0x00, 0x22, 0x08, 0xB6, 0x00, 0x60, 0x00, 0xF6, 0xFF, 0x25, 0x0A, 0xA1, 0x00, 0x67, 0x00, 0x00, 0x00, 0x3A, 0x08, 0xB5, 0x00, 0xB9, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x02, 0x00, 0x01, 0xE3, 0x02, 0x0E, 0x49, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xD2, 0x19, 0x02, 0x00, 0xBC, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xDC, 0x02, 0x18, 0x49, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xD2, 0x19, 0x16, 0x01, 0xAB, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01 };

this.AddRoomItemsByteBlock(roomItems);
byte[] npcs = { 0x17, 0x0B, 0x0F, 0x49, 0x01, 0x00, 0x00, 0xFF, 0x00, 0x0C, 0x08, 0x64, 0x64, 0x01, 0x00, 0x01, 0x0A, 0x00, 0x42, 0x72, 0x61, 0x79, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x01, 0xD2, 0x19, 0xB6, 0x00, 0xA6, 0x00, 0x02, 0x00, 0x08, 0x00, 0x01, 0x73, 0x04, 0x10, 0x49, 0x01, 0x00, 0x63, 0x00, 0x01, 0x0A, 0x00, 0x43, 0x68, 0x61, 0x69, 0x6E, 0x20, 0x56, 0x65, 0x73, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x96, 0x04, 0x11, 0x49, 0x01, 0x00, 0x63, 0x00, 0x01, 0x0E, 0x00, 0x43, 0x68, 0x61, 0x69, 0x6E, 0x20, 0x4C, 0x65, 0x67, 0x67, 0x69, 0x6E, 0x67, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xFB, 0x04, 0x12, 0x49, 0x01, 0x00, 0x63, 0x00, 0x01, 0x0A, 0x00, 0x43, 0x68, 0x61, 0x69, 0x6E, 0x20, 0x43, 0x6F, 0x77, 0x6C, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAB, 0x04, 0x13, 0x49, 0x01, 0x00, 0x5E, 0x00, 0x01, 0x0A, 0x00, 0x48, 0x69, 0x67, 0x68, 0x20, 0x42, 0x6F, 0x6F, 0x74, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0x17, 0x49, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x03, 0x01, 0x05, 0x02, 0x01, 0x05, 0x08, 0x04, 0x00, 0x06, 0x03, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddNpcsByteBlock(npcs);
base.ApplyRoomLayout();
}
}
}
