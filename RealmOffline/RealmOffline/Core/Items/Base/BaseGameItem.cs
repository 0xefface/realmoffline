using RealmOffline.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



/* 
  this needs fixed

*/
namespace RealmOffline.Core.Items.Base
{
    public abstract class BaseGameItem : Entity
    {
        private ushort graphicID;
        public override ushort GraphicID
        {
            get { return graphicID; }
            set { graphicID = value; }
        }
        private uint gameID;
        public override uint GameID
        {
            get { return gameID; }
            set { gameID = value; }
        }
        private ushort color;
        public override ushort Color
        {
            get { return color; }
            set { color = value; }
        }
        private string itemName = "";
        public override string Name
        {
            get { return itemName; }
            set { itemName = value; }
        }
        private List<byte> enchantments;
        public List<byte> Enchantments
        {
            get
            {
                if (enchantments == null)
                    enchantments = new List<byte>();
                return enchantments;
            }
            set { enchantments = value; }
        }
        private byte moneyType;
        public byte MoneyType
        {
            get { return moneyType; }
            set { moneyType = value; }
        }
        private RoomLocation location;
        public RoomLocation Location
        {
            get { return location; }
            set { location = value; }
        }
        private bool equipped;
        public bool Equipped
        {
            get { return equipped; }
            set { equipped = value; }
        }
        private bool isContainer;
        public bool IsContainer
        {
            get { return isContainer; }
            set { isContainer = value; }
        }
        private List<BaseGameItem> containedItems;
        public List<BaseGameItem> ContainedItems
        {
            get
            {
                if (containedItems == null)
                    containedItems = new List<BaseGameItem>();
                return containedItems;
            }
            set { containedItems = value; }
        }
        private int sqlID;
        public int SqlID
        {
            get { return sqlID; }
            set { sqlID = value; }
        }
        private int val;
        public int Value
        {
            get { return val; }
            set { val = value; }
        }
        private uint sqlOwnerID;
        public uint SqlOwnerID
        {
            get { return sqlOwnerID; }
            set { sqlOwnerID = value; }
        }
        private ItemType type;
        public ItemType Type
        {
            get { return type; }
            set { type = value; }
        }
        private string lookAt;
        public string LookAt
        {
            get { return lookAt; }
            set { lookAt = value; }
        }
        private bool isEquipable;
        public bool IsEquipable
        {
            get { return isEquipable; }
            set { isEquipable = value; }
        }
        private EquipmentSlot equipableSlot = EquipmentSlot.None;
        public EquipmentSlot EquipableSlot
        {
            get { return equipableSlot; }
            set { equipableSlot = value; }
        }
        private byte isBook;
        public byte IsBook
        {
            get { return isBook; }
            set { isBook = value; }
        }
        private byte isLocked;
        public byte IsLocked
        {
            get { return IsLocked; }
            set { isLocked = value; }
        }
        private byte isSittingOn;
        public byte IsSittingOn
        {
            get { return isSittingOn; ; }
            set { isSittingOn = value; }
        }
        private byte canTalk;
        public byte CanTalk
        {
            get { return canTalk; }
            set { canTalk = value; }
        }
        private byte isInvisible;
        public byte IsInvisible
        {
            get { return isInvisible; }
            set { isInvisible = value; }
        }
        private byte isInCombat;
        public byte IsInCombat
        {
            get { return isInCombat; }
            set { isInCombat = value; }
        }
        private short armorFactor;
        public short ArmorFactor
        {
            get { return armorFactor; }
            set { armorFactor = value; }
        }
        private short durability;
        public short Durability
        {
            get { return durability; }
            set { durability = value; }
        }
        private short minimumDamage;
        public short MinimumDamage
        {
            get { return minimumDamage; }
            set { minimumDamage = value; }
        }
        private short maximumDamage;
        public short MaximumDamage
        {
            get { return maximumDamage; }
            set { maximumDamage = value; }
        }
        private bool isGoldOrMana;
        public bool IsGoldOrMana
        {
            get { return isGoldOrMana; }
            set { isGoldOrMana = value; }
        }
        private bool isIdentified;
        public bool IsIdentified
        {
            get { return isIdentified; }
            set
            {
                if (value == true)
                {
                    if (!this.Enchantments.Contains(0x20)) this.Enchantments.Add(0x20);
                }
                else
                {
                    if (this.Enchantments.Contains(0x20)) this.Enchantments.Remove(0x20);
                }
                isIdentified = value;
            }
        }
        public virtual void AssignToRoom(RoomLocation location)
        {
            this.Location = new RoomLocation(location.CurrentRoom.RoomID, location.X, location.Y, 0);
            this.Location.CurrentRoom = location.CurrentRoom;
        }
        public virtual void RemoveFromRoom()
        {
            this.Location = null;
        }
        public override byte[] Serialize(out uint itemid)
        {
            // we want to turn this item into a game packet from a item
            PacketWriter w = new PacketWriter();
            w.WriteByte(1);
            w.WriteUShort(this.GraphicID);
            itemid = ServerGlobals.GetNextAvailableID();
           // this.SetCharSlotID(itemid);
            //Console.WriteLine("(Serialize):Set item with graphic id of {0} to {1}", this.GraphicID, this.ID);
            w.WriteUInt32(itemid);
            w.WriteUShort(this.Color);
            if (!string.IsNullOrEmpty(this.Name))
            {
                w.WriteByte(1);
                w.WriteString(Name);
                w.WriteByte(0x4A);
                w.WriteByte(0x00);
                w.WriteByte(0xFF);
            }
            else w.WriteBytes(new byte[] { 0x00, 0x00, 0xFF });
            w.WriteByte(0x00);

            if (this.Location != null)
            {
                if (this.Location.CurrentRoom.RoomID < 65534)
                {
                    w.WriteByte(0x01);
                    w.WriteShort((short)this.Location.CurrentRoom.RoomID);
                }
                else
                {
                    w.WriteByte(0x02);
                    w.WriteUInt32(this.Location.CurrentRoom.RoomID);
                }
                w.WriteUShort(this.Location.X);
                w.WriteUShort(this.Location.Y);
                w.WriteShort(0x01);

            }
            else w.WriteByte(0x00); // if this has a value, than item is in a room
            w.WriteByte(0x01);
            w.WriteByte((byte)(this.isEquipable ? 1:0)); // not equiped
            w.WriteShort(0); // hmm ? stats ?
            w.WriteShort(0); // hmm ?
            //w.WriteShort(0);
            return w.GetRawPacket();
        }
        public virtual byte[] Serialize()
        {
            // we want to turn this item into a game packet from a item
            PacketWriter w = new PacketWriter();
            w.WriteByte(1);
            w.WriteUShort(this.GraphicID);
            w.WriteUInt32(this.GameID);
            w.WriteUShort(this.Color);
            if (!string.IsNullOrEmpty(this.Name))
            {
                w.WriteByte(1);
                w.WriteString(Name);

                // In here or below we hold more info
                // before FF we normally see  
                w.WriteByte(0x4A); // this means engraved ? store got 0x20 given 0x00 ?
                w.WriteByte(0x20); // 20 means identified
                w.WriteByte(0xFF);
            }

            /*
             * Noticed changes after name we have more bytes before 0xFF
             * I assume by adding more bytes here, we add more spells.
             * 0x20 adds if bought at store, then when i casted str with no enchant
             * 0x00 = given or picked up loot ?
             * 0x20 = store bought
             * 0x4A = Engraved
             * 0x27 = Casted Str
             * 0x3B = casted dex, looks like it adds bytes as the were casted
             * 0x16 = open enchant
             * When you cast a spell on a item, it assigns the byte
             * then saves in the item database that it is a temp buff
             * because it saves the bytes just like it was enchanted
             * or permed.
             * 
             */
            else w.WriteBytes(new byte[] { 0x00, 0x20, 0xFF }); // 20 means identified.

            w.WriteByte(0x00);
            if (this.Location != null)
            {
                if (this.Location.CurrentRoom.RoomID < 65534)
                {
                    w.WriteByte(0x01);
                    w.WriteShort((short)this.Location.CurrentRoom.RoomID);
                }
                else
                {
                    w.WriteByte(0x02);
                    w.WriteUInt32(this.Location.CurrentRoom.RoomID);
                }
                w.WriteUShort(this.Location.X);
                w.WriteUShort(this.Location.Y);
                w.WriteByte(0x00);
            }
            else w.WriteByte(0x00); // if this has a value, than item is in a room
            w.WriteByte(0x01); // think this is if its wearable ?
            w.WriteByte((byte)(this.isEquipable ? 1 : 0)); // not equiped
            w.WriteByte(0x00);
            w.WriteByte(0x00);

            w.WriteByte(0x00); // crashed
            w.WriteByte(0x00); // adds talk to items

            w.WriteByte(0x00);
            w.WriteByte(0x00);
            return w.GetRawPacket();
        }

        #region Old
        /*
        public override byte[] Serialize(out uint id)
        {
            id = ServerGlobals.GetNextAvailableID();
            this.GameID = id;
            Packets.PacketWriter w = new Packets.PacketWriter();
            w.WriteByte(0x01);
            w.WriteUShort(this.GraphicID);
            w.WriteUInt32(this.GameID);
            w.WriteUShort(this.Color); // color
            if (string.IsNullOrEmpty(this.Name))
                w.WriteByte(0x00); // 1 here if name follows, then followed by 2 bytes with length of naem
            else
            {
                w.WriteByte(0x01);
                w.WriteString(this.Name); // prefixes the string with a short length
            }
            // right after name, if this item is engraved with a custom name
            // the spell byte is 0x4A
            if (!string.IsNullOrEmpty(this.Name))
                w.WriteByte(0x4A);
            else w.WriteByte(0x00);
            // identified, added later ? yes
            // how to handle buffs ?
           // if (this.Enchantments.Count == 0)
           //     w.WriteUShort(0x00);
           // else
           // {
                foreach (byte b in this.Enchantments)
                {
                    w.WriteByte(b);
                    //Console.WriteLine("Wrote {0} for {1}.", b.ToString("X2"), this.GameID);
                }
          //  }
            w.WriteByte(0xFF); // buff end
            w.WriteByte(MoneyType); // MoneyType
            // Roomlocation, if in a room
            #region Room and Location bytes
            if (this.Location == null)
            {
                w.WriteByte(0x00); // no location isInRoom
            }
            else
            {
                if (this.Location.CurrentRoom != null)
                {
                    if (this.Location.CurrentRoom.RoomID <= 65535)
                    {
                        w.WriteByte(0x01);
                        w.WriteUShort((ushort)this.Location.CurrentRoom.RoomID);
                    }
                    else
                    {
                        w.WriteByte(0x02);
                        w.WriteUInt32(this.Location.CurrentRoom.RoomID);
                    }
                    w.WriteUShort(this.Location.X);
                    w.WriteUShort(this.Location.Y);
                    w.WriteUShort(this.Location.Facing);
                }
               // else w.WriteByte(0x00);// we do not know what happened, a locations room should never be null
            }
            // Ok locations done
            #endregion
            int i = this.IsEquipable ? 1 : 0;
            w.WriteByte((byte)i); // Not sure most items have this
            int e = this.Equipped ? 1 : 0;
            w.WriteByte((byte)e);
            w.WriteByte(isBook); // isBook
            // Starts info for containers
            if (this.IsContainer)
            {
                w.WriteShort((short)this.ContainedItems.Count);
                // Followed by items contained
            }
            else w.WriteShort(0x00);

            /*
            w.WriteByte(isLocked);
            w.WriteByte(isSittingOn);
            w.WriteByte(canTalk);
            w.WriteByte(isInvisible);
            w.WriteByte(isInCombat);
            
            w.WriteByte(0x00);
            w.WriteUInt32(0x00);
            return w.GetRawPacket();
        }
        public virtual byte[] Serialize()
        {
            Packets.PacketWriter w = new Packets.PacketWriter();
            w.WriteByte(0x01);
            w.WriteUShort(this.GraphicID);
            w.WriteUInt32(this.GameID);
            w.WriteUShort(this.Color); // color
            if (string.IsNullOrEmpty(this.Name))
                w.WriteByte(0x00); // 1 here if name follows, then followed by 2 bytes with length of naem
            else
            {
                w.WriteByte(0x01);
                w.WriteString(this.Name); // prefixes the string with a short length
            }
            // right after name, if this item is engraved with a custom name
            // the spell byte is 0x4A
            if (!string.IsNullOrEmpty(this.Name))
                w.WriteByte(0x4A);
            else w.WriteByte(0x00);
            // identified, added later ? yes
            // how to handle buffs ?
           // if (this.Enchantments.Count == 0)
           //     w.WriteUShort(0x00);
          //  else
          //  {
                foreach (byte b in this.Enchantments)
                {
                    w.WriteByte(b);
                    //Console.WriteLine("Wrote {0} for {1}.", b.ToString("X2"), this.GameID);
                }
         //   }
            w.WriteByte(0xFF); // buff end
            w.WriteByte(moneyType); // moneyType
            // Roomlocation, if in a room
            #region Room and Location bytes
            if (this.Location == null) w.WriteByte(0x00); // no location
            else
            {
                if (this.Location.CurrentRoom != null)
                {
                    if (this.Location.CurrentRoom.RoomID <= 65535)
                    {
                        w.WriteByte(0x01);
                        w.WriteUShort((ushort)this.Location.CurrentRoom.RoomID);
                    }
                    else
                    {
                        w.WriteByte(0x02);
                        w.WriteUInt32(this.Location.CurrentRoom.RoomID);
                    }
                    w.WriteUShort(this.Location.X);
                    w.WriteUShort(this.Location.Y);
                    w.WriteUShort(this.Location.Facing);
                }
               // else w.WriteByte(0x00);// we do not know what happened, a locations room should never be null
            }
            // Ok locations done
            #endregion
            int i = this.isEquipable ? 0x01 : 0x00;
            w.WriteByte((byte)i); // Not sure most items have this
            int e = this.Equipped ? 1 : 0;
            w.WriteByte((byte)e);
            w.WriteByte(isBook); // isBook
            // Starts info for containers
            if (this.IsContainer)
            {
                w.WriteShort((short)this.ContainedItems.Count);
                // Followed by items contained
            }
            else w.WriteShort(0x00);
            /*
            w.WriteByte(isLocked);
            w.WriteByte(isSittingOn);
            w.WriteByte(canTalk);
            w.WriteByte(isInvisible);
            w.WriteByte(isInCombat);
            
              w.WriteByte(0x00);
             w.WriteUInt32(0x00);
            return w.GetRawPacket();
        }
        */
        #endregion
        public override void Deserialize(byte[] data)
        {
        }
    }
}
