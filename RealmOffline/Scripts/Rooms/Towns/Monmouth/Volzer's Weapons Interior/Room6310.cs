using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room6310 : Room
{
public Room6310()
: base(6310, "Volzer's Weapons Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
byte[] roomDecItems = { 0x17, 0xDD, 0x07, 0x18, 0x01, 0x17, 0x00, 0x00, 0x00, 0xE9, 0x07, 0x7D, 0x01, 0x0F, 0x00, 0x00, 0x00, 0xAD, 0x08, 0x44, 0x02, 0xAB, 0x00, 0x00, 0x00, 0xDD, 0x07, 0x5D, 0x00, 0x01, 0x00, 0xEA, 0xFF, 0xDE, 0x07, 0x0B, 0x00, 0x02, 0x00, 0xD2, 0xFF, 0xEA, 0x07, 0xEE, 0x01, 0x18, 0x00, 0x00, 0x00, 0x3D, 0x08, 0xAB, 0x01, 0xB3, 0x00, 0x00, 0x00, 0xF9, 0x07, 0x20, 0x00, 0x95, 0x00, 0x00, 0x00, 0x48, 0x88, 0xAF, 0x01, 0xB4, 0x00, 0x3A, 0x00, 0xF0, 0x09, 0x0C, 0x01, 0x91, 0x00, 0x10, 0x00, 0x74, 0x08, 0x74, 0x00, 0x59, 0x00, 0x00, 0x00, 0x74, 0x08, 0x0D, 0x00, 0x2D, 0x00, 0xC0, 0xFF, 0x3D, 0x08, 0x15, 0x02, 0x18, 0x01, 0x00, 0x00, 0x3D, 0x08, 0x34, 0x00, 0x0D, 0x01, 0x00, 0x00, 0x48, 0x08, 0x36, 0x01, 0xEC, 0x00, 0x3A, 0x00, 0xF0, 0x09, 0x2C, 0x00, 0x98, 0x00, 0x10, 0x00, 0xD1, 0x07, 0xB9, 0x00, 0x17, 0x00, 0x00, 0x00, 0x49, 0x08, 0x1C, 0x02, 0x19, 0x01, 0x22, 0x00, 0x49, 0x08, 0x3B, 0x00, 0x0E, 0x01, 0x22, 0x00, 0x37, 0x08, 0x30, 0x01, 0xEB, 0x00, 0x00, 0x00, 0xF9, 0x07, 0x00, 0x01, 0x8E, 0x00, 0x00, 0x00, 0x76, 0x08, 0x75, 0x01, 0x44, 0x00, 0x00, 0x00, 0x76, 0x08, 0xEA, 0x01, 0x43, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x02, 0x00, 0x01, 0xDB, 0x02, 0xAA, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA6, 0x18, 0xB5, 0x00, 0xBB, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE3, 0x02, 0xAB, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA6, 0x18, 0x71, 0x02, 0xBC, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01 };

this.AddRoomItemsByteBlock(roomItems);
byte[] npcs = { 0x17, 0x0B, 0xAC, 0x4E, 0x01, 0x00, 0x00, 0xFF, 0x00, 0x0C, 0x08, 0x6E, 0x6E, 0x01, 0x00, 0x00, 0x0C, 0x00, 0x56, 0x6F, 0x6C, 0x7A, 0x65, 0x72, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0x90, 0x09, 0x00, 0x00, 0x90, 0x09, 0x00, 0x00, 0x01, 0xA6, 0x18, 0x30, 0x01, 0xDB, 0x00, 0x00, 0x00, 0x07, 0x00, 0x01, 0x73, 0x04, 0xAD, 0x4E, 0x01, 0x00, 0x63, 0x00, 0x01, 0x0A, 0x00, 0x43, 0x68, 0x61, 0x69, 0x6E, 0x20, 0x56, 0x65, 0x73, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x96, 0x04, 0xAE, 0x4E, 0x01, 0x00, 0x63, 0x00, 0x01, 0x0E, 0x00, 0x43, 0x68, 0x61, 0x69, 0x6E, 0x20, 0x4C, 0x65, 0x67, 0x67, 0x69, 0x6E, 0x67, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x0E, 0x05, 0xAF, 0x4E, 0x01, 0x00, 0x62, 0x00, 0x01, 0x04, 0x00, 0x42, 0x65, 0x6C, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAA, 0x04, 0xB0, 0x4E, 0x01, 0x00, 0x62, 0x00, 0x01, 0x0A, 0x00, 0x48, 0x69, 0x67, 0x68, 0x20, 0x42, 0x6F, 0x6F, 0x74, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0xB3, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x02, 0x00, 0x04, 0x09, 0x05, 0x07, 0x08, 0x05, 0x09, 0x0A, 0x03, 0x06, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 };

this.AddNpcsByteBlock(npcs);
base.ApplyRoomLayout();
}
}
}