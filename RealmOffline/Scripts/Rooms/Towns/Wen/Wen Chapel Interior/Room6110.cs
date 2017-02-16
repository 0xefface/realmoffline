using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room6110 : Room
{
public Room6110()
: base(6110, "Wen Chapel Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
byte[] roomDecItems = { 0x23, 0xD4, 0x07, 0x37, 0x02, 0x05, 0x00, 0x37, 0x00, 0xEA, 0x07, 0x26, 0x01, 0x04, 0x00, 0x00, 0x00, 0xEA, 0x07, 0xA4, 0x01, 0x04, 0x00, 0x00, 0x00, 0xEA, 0x07, 0xAC, 0x00, 0x03, 0x00, 0x00, 0x00, 0xE9, 0x07, 0xFD, 0x01, 0x02, 0x00, 0x07, 0x00, 0xE9, 0x07, 0x94, 0x00, 0x02, 0x00, 0x08, 0x00, 0xE0, 0x07, 0x5E, 0x00, 0x04, 0x00, 0x37, 0x00, 0x22, 0x08, 0xC8, 0x01, 0x33, 0x00, 0x00, 0x00, 0x22, 0x08, 0x43, 0x01, 0x30, 0x00, 0x00, 0x00, 0x22, 0x08, 0xC3, 0x00, 0x31, 0x00, 0x00, 0x00, 0x28, 0x08, 0xC8, 0x01, 0x41, 0x00, 0x00, 0x00, 0x22, 0x08, 0xC3, 0x00, 0x7E, 0x00, 0x00, 0x00, 0x22, 0x08, 0x44, 0x01, 0x7C, 0x00, 0x00, 0x00, 0x22, 0x08, 0xC9, 0x01, 0x80, 0x00, 0x00, 0x00, 0x25, 0x0A, 0x2F, 0x01, 0x87, 0x00, 0x0A, 0x00, 0x25, 0x0A, 0xB4, 0x01, 0x88, 0x00, 0x0A, 0x00, 0x25, 0x0A, 0xAE, 0x00, 0x86, 0x00, 0x0A, 0x00, 0x25, 0x0A, 0xAE, 0x00, 0x39, 0x00, 0x0A, 0x00, 0x25, 0x0A, 0x2E, 0x01, 0x38, 0x00, 0x0A, 0x00, 0x25, 0x0A, 0xB3, 0x01, 0x3B, 0x00, 0x0A, 0x00, 0x28, 0x08, 0xC9, 0x01, 0x8E, 0x00, 0x00, 0x00, 0x73, 0x08, 0x12, 0x01, 0x3E, 0x00, 0x00, 0x00, 0x73, 0x08, 0x78, 0x01, 0x3D, 0x00, 0x00, 0x00, 0x73, 0x08, 0x0D, 0x02, 0x50, 0x00, 0x00, 0x00, 0x73, 0x08, 0x97, 0x01, 0x5E, 0x00, 0x00, 0x00, 0x73, 0x08, 0xF1, 0x00, 0x5E, 0x00, 0x00, 0x00, 0x73, 0x08, 0x83, 0x00, 0x4A, 0x00, 0x00, 0x00, 0x37, 0x08, 0x45, 0x01, 0x27, 0x01, 0x00, 0x00, 0x28, 0x08, 0xC3, 0x00, 0x3F, 0x00, 0x00, 0x00, 0x28, 0x08, 0xC3, 0x00, 0x8C, 0x00, 0x00, 0x00, 0x28, 0x08, 0x43, 0x01, 0x3E, 0x00, 0x00, 0x00, 0x28, 0x08, 0x44, 0x01, 0x8D, 0x00, 0x00, 0x00, 0x21, 0x08, 0x74, 0x02, 0x7A, 0x00, 0x00, 0x00, 0x24, 0x0A, 0x4E, 0x02, 0x85, 0x00, 0x11, 0x00, 0x27, 0x08, 0x88, 0x02, 0x8D, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x10, 0x00, 0x01, 0xDC, 0x02, 0xC2, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDE, 0x17, 0x2D, 0x00, 0xA4, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xC3, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDE, 0x17, 0xB6, 0x00, 0xCD, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xC4, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDE, 0x17, 0x7F, 0x00, 0xA3, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xC5, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDE, 0x17, 0x95, 0x00, 0xD4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xC6, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDE, 0x17, 0xED, 0x00, 0xCD, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xC7, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDE, 0x17, 0x24, 0x01, 0xCD, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xC8, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDE, 0x17, 0x5A, 0x01, 0xCD, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xC9, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDE, 0x17, 0x0C, 0x02, 0xA5, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xCA, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDE, 0x17, 0x8F, 0x01, 0xCD, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xCB, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDE, 0x17, 0xC0, 0x01, 0xCD, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xCC, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDE, 0x17, 0xEF, 0x01, 0xCD, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xCD, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDE, 0x17, 0x38, 0x02, 0xE3, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xCE, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDE, 0x17, 0x64, 0x02, 0xF6, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xCF, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDE, 0x17, 0x10, 0x02, 0xD4, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xD0, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDE, 0x17, 0x3F, 0x00, 0xF7, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xD1, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDE, 0x17, 0x6A, 0x00, 0xE4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1C, 0x8B, 0xA4, 0xF9 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
