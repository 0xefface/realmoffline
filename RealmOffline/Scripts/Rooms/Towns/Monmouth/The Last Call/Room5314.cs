using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5314 : Room
{
public Room5314()
: base(5314, "The Last Call")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x22, 0xC5, 0x09, 0x80, 0x00, 0x2F, 0x00, 0x00, 0x00, 0xC5, 0x09, 0x9A, 0x00, 0x32, 0x00, 0x00, 0x00, 0xC6, 0x09, 0x8C, 0x00, 0x40, 0x00, 0x00, 0x00, 0xD8, 0x09, 0x28, 0x01, 0x20, 0x00, 0x00, 0x00, 0xC8, 0x09, 0x7C, 0x01, 0xF3, 0xFF, 0x00, 0x00, 0xD9, 0x09, 0x60, 0x02, 0x8E, 0x00, 0x00, 0x00, 0xC8, 0x09, 0x7F, 0x01, 0x05, 0x00, 0x00, 0x00, 0x99, 0x0A, 0x54, 0x01, 0x8D, 0x00, 0x50, 0x00, 0xF0, 0x09, 0xE3, 0x00, 0xAE, 0x00, 0x14, 0x00, 0xED, 0x09, 0xD7, 0x00, 0xA7, 0x00, 0x00, 0x00, 0xEE, 0x09, 0xD8, 0x01, 0xA3, 0x00, 0x00, 0x00, 0xEE, 0x09, 0xA0, 0x00, 0x9D, 0x00, 0x00, 0x00, 0xF1, 0x09, 0xD4, 0x01, 0xB5, 0x00, 0x14, 0x00, 0xF1, 0x09, 0xA0, 0x00, 0xAC, 0x00, 0x14, 0x00, 0x9A, 0x0A, 0x01, 0x01, 0x52, 0x00, 0x00, 0x00, 0x17, 0x00, 0xFE, 0xFF, 0x3B, 0x00, 0x00, 0x00, 0x9A, 0x0A, 0xBF, 0x00, 0x47, 0x00, 0x00, 0x00, 0x14, 0x00, 0x97, 0x02, 0xCB, 0x00, 0x00, 0x00, 0x03, 0x00, 0xE9, 0x00, 0xD4, 0x00, 0x00, 0x00, 0x03, 0x00, 0x55, 0x00, 0xCE, 0x00, 0x00, 0x00, 0x2F, 0x8A, 0x33, 0x02, 0x9B, 0x00, 0x00, 0x00, 0x2F, 0x8A, 0x87, 0x02, 0x85, 0x00, 0x00, 0x00, 0x30, 0x0A, 0xBD, 0x00, 0x46, 0x00, 0x00, 0x00, 0x17, 0x80, 0x42, 0x00, 0x19, 0x00, 0x00, 0x00, 0x8A, 0x0B, 0x9F, 0x00, 0xE0, 0x00, 0x00, 0x00, 0x89, 0x0B, 0x5B, 0x02, 0xE2, 0x00, 0x00, 0x00, 0x14, 0x00, 0x2B, 0x02, 0xD8, 0x00, 0x00, 0x00, 0x14, 0x80, 0x73, 0x02, 0xDE, 0x00, 0x00, 0x00, 0xF8, 0x0A, 0x78, 0x01, 0x7B, 0x00, 0x00, 0x00, 0x96, 0x0A, 0x6B, 0x01, 0x47, 0x00, 0x00, 0x00, 0xED, 0x0A, 0x6A, 0x01, 0x88, 0x00, 0x00, 0x00, 0x16, 0x80, 0x13, 0x02, 0x29, 0x01, 0x00, 0x00, 0x15, 0x80, 0x32, 0x02, 0x08, 0x01, 0x00, 0x00, 0x15, 0x00, 0x90, 0x02, 0xEF, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xDB, 0x02, 0x69, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xC2, 0x14, 0x42, 0x01, 0xCA, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}