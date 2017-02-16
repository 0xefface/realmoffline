using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RealmOffline.Core
{
    // All items
    public class GameEntity
    {
        public ushort ClassID;
        /// <summary>
        /// This is Class for character
        /// </summary>
        public ushort GraphicID;
        public uint GameID;
        public ushort Color;
        public string Name;
        /// <summary>
        /// Only set this if we are gold or mana
        /// </summary>
        public uint Value;

        public List<byte> affectedStates;

        public byte XSpeed;
        public byte YSpeed;
        public byte Width;
        public byte Height;
        public byte Profession;
        public byte Race;
        public byte Gender;
        public byte Peaceful;
        public uint CurrentHealth;
        public uint MaximumHealth;
        public byte CanTalk;
        public byte IsInvisible;
        public GameLocation Location;

        public GameMobileHead Head;

        public GameEntity()
        {
            affectedStates = new List<byte>();
            Name = "";
            Value = 0;
        }


        public virtual MemoryStream ToStream()
        {
            MemoryStream _stream = new MemoryStream();
            BinaryWriter _writer = new BinaryWriter(_stream);

            _writer.Write((byte)0x01);
            _writer.Write(GraphicID);
            _writer.Write(GameID);

            if(this is GameMobile == false)
            {
                _writer.Write(Color);
            }

            // empty byte here ?
            _writer.Write((byte)Name.Length > 0);

            if(this is GameItem)
            {
                // Custom Engraved name ?
                if(!string.IsNullOrEmpty(Name))
                {
                    _writer.Write(LengthPrefixedString(Name));
                }
            }

            if(this is GameCharacter)
            {
                _writer.Write((byte)0x00);
                _writer.Write((byte)0x53);
                _writer.Write((byte)0x54);
            }

            foreach (byte a in affectedStates) _writer.Write(a);
            _writer.Write((byte)0xFF);


            if (Value == 0) _writer.Write((byte)0x00); // Money section

            else if(Value < 0xFFFF)
            {
                _writer.Write((byte)0x01);
                _writer.Write((ushort)Value);
            }
            else
            {
                _writer.Write((byte)0x02);
                _writer.Write(Value);
            }

            if(this is GameMobile || this is GameCharacter)
            {
                // Now only NPC's need this data
                // Mobs do not
                _writer.Write(XSpeed); //0C
                _writer.Write(YSpeed);// 08
                _writer.Write(Width);
                _writer.Write(Height);
                _writer.Write(Profession);
                _writer.Write(Race);
                _writer.Write(Gender);
                _writer.Write(LengthPrefixedString(Name));
                _writer.Write(Peaceful);
                _writer.Write(CurrentHealth);
                _writer.Write(MaximumHealth);
            }

            if(Location == null)
            {
                _writer.Write((byte)0x00); // isinroom
            }
            else
            {
                byte roomStatus = 0x00;

                //if (!Location.DoScaler) roomStatus |= 0x10;

                if (Location.RoomNumber <= 0xFFFF) roomStatus |= 0x01;
                else roomStatus |= 0x02;

                _writer.Write(roomStatus);

                if (Location.RoomNumber <= 0xFFFF) _writer.Write((ushort)Location.RoomNumber);
                else _writer.Write(Location.RoomNumber);

                _writer.Write(Location.X);
                _writer.Write(Location.Y);
                _writer.Write(Location.Facing);
            }

            if (this is GameCarryable)
            {
                GameCarryable o = this as GameCarryable;
                _writer.Write(o.isVisible);
            }
            else if(this is GameMobile == false)_writer.Write((byte)0x00);

            if(this is GameWeapon)
            {
                GameWeapon o = this as GameWeapon;
                _writer.Write(o.isWorn);
            }
            
            if(this is GameMobile)
            {
              //  _writer.Write((byte)0x00);
                GameMobile o = this as GameMobile;

                if (o.Inventory != null)
                {
                    _writer.Write((ushort)(o.Inventory.Count + 1));
                    _writer.Write((byte)0x01);
                    _writer.Write((ushort)0x04);
                    _writer.Write(ServerGlobals.GetNextAvailableID());
                    _writer.Write((ushort)0x00);
                    _writer.Write((byte)0x00);
                    _writer.Write((byte)0xFF);
                    _writer.Write((ushort)0x00);
                    _writer.Write((byte)0x00);
                }
                else _writer.Write((ushort)0x00);
            }

            if(Head != null)
            {
                _writer.Write(Head.ToArray());
              //  _writer.Write((byte)0x00); // wont appear on screen unless i do this
            }
            // 6 bytes after head start inventory
            if (this is GameWearable)
            {
                GameWearable o = this as GameWearable;
                _writer.Write(o.isWorn);
            }
            else _writer.Write((byte)0x00);

            if (this is GameDescribed)
            {
                GameDescribed o = this as GameDescribed;
                _writer.Write(o.isBook);
            }
            else _writer.Write((byte)0x00);

            if(this is GameContainer)
            {
                GameContainer o = this as GameContainer;
                _writer.Write((ushort)o.Items.Count);

                foreach(GameEntity e in o.Items)
                {
                    _writer.Write(e.ToByteArray());
                }
            }
            /*
            // do we have a inventory ?

            if (this is GameMobile)
            {
                GameMobile o = this as GameMobile;

                if (o.Inventory != null)
                {

                 //   _writer.Write((ushort)0x01);//(o.Inventory.Count)); // works if it has 00 inventory
                    _writer.Write((byte)0x01);
                    _writer.Write((ushort)0x04);
                    _writer.Write(ServerGlobals.GetNextAvailableID());
                    _writer.Write((ushort)0x00);
                    _writer.Write((byte)0x00);
                    _writer.Write((byte)0xFF);
                    _writer.Write((ushort)0x00);
                    _writer.Write((byte)0x00);
                }
            }
            */
            if (this is GameOpenable)
            {
                GameOpenable o = this as GameOpenable;
                _writer.Write(o.isOpen);
            }

            if(this is GameSwitch)
            {
                GameSwitch o = this as GameSwitch;
                _writer.Write(o.SwitchState);
            }

            byte lockState = 0;
            _writer.Write(lockState);

            byte sitState = 0;
            _writer.Write(sitState);

            _writer.Write(CanTalk);

            _writer.Write(IsInvisible);

            byte combatState = 0;
            _writer.Write(combatState);

            if(this is GameMobile)
            {
               // _writer.Write((ushort)0x00);
               // _writer.Write((byte)0xFF);
            }
            _stream.Position = 0;
            return _stream;
        }
        public virtual byte[] ToByteArray()
        {
            return ToStream().ToArray();
        }
        

        public byte[] LengthPrefixedString(string text)
        {
            MemoryStream _stream = new MemoryStream();
            BinaryWriter _writer = new BinaryWriter(_stream);

            byte[] data = Encoding.ASCII.GetBytes(text);

            _writer.Write((ushort)data.Length);

            _writer.Write(data);

            return _stream.ToArray();
        }
    }
}
#region Works for all except those with heads
/*
 public virtual MemoryStream ToStream()
        {
            MemoryStream _stream = new MemoryStream();
            BinaryWriter _writer = new BinaryWriter(_stream);

            _writer.Write((byte)0x01);
            _writer.Write(GraphicID);
            _writer.Write(GameID);

            if(this is GameMobile == false)
            {
                _writer.Write(Color);
            }

            // empty byte here ?
            _writer.Write((byte)Name.Length > 0);

            if(this is GameItem)
            {
                // Custom Engraved name ?
                if(!string.IsNullOrEmpty(Name))
                {
                    _writer.Write(LengthPrefixedString(Name));
                }
            }

            foreach (byte a in affectedStates) _writer.Write(a);
            _writer.Write((byte)0xFF);

            if (Value == 0) _writer.Write((byte)0x00); // Money section

            else if(Value < 0xFFFF)
            {
                _writer.Write((byte)0x01);
                _writer.Write((ushort)Value);
            }
            else
            {
                _writer.Write((byte)0x02);
                _writer.Write(Value);
            }

            if(this is GameMobile)
            {
                // Now only NPC's need this data
                // Mobs do not
                _writer.Write(XSpeed);
                _writer.Write(YSpeed);
                _writer.Write(Width);
                _writer.Write(Height);
                _writer.Write(Profession);
                _writer.Write(Race);
                _writer.Write(Gender);
                _writer.Write(LengthPrefixedString(Name));
                _writer.Write(Peaceful);
                _writer.Write(CurrentHealth);
                _writer.Write(MaximumHealth);
            }

            if(Location == null)
            {
                _writer.Write((byte)0x00); // isinroom
            }
            else
            {
                byte roomStatus = 0x00;

                //if (!Location.DoScaler) roomStatus |= 0x10;

                if (Location.RoomNumber <= 0xFFFF) roomStatus |= 0x01;
                else roomStatus |= 0x02;

                _writer.Write(roomStatus);

                if (Location.RoomNumber <= 0xFFFF) _writer.Write((ushort)Location.RoomNumber);
                else _writer.Write(Location.RoomNumber);

                _writer.Write(Location.X);
                _writer.Write(Location.Y);
                _writer.Write(Location.Facing);
            }

            if (this is GameCarryable)
            {
                GameCarryable o = this as GameCarryable;
                _writer.Write(o.isVisible);
            }
            else if(this is GameMobile == false)_writer.Write((byte)0x00);

            if(this is GameWeapon)
            {
                GameWeapon o = this as GameWeapon;
                _writer.Write(o.isWorn);
            }
            
            if(this is GameMobile)
            {
              //  _writer.Write((byte)0x00);
                GameMobile o = this as GameMobile;

                if (o.Inventory != null)
                {
                    _writer.Write((ushort)(o.Inventory.Count + 1));
                    _writer.Write((byte)0x01);
                    _writer.Write((ushort)0x04);
                    _writer.Write(ServerGlobals.GetNextAvailableID());
                    _writer.Write((ushort)0x00);
                    _writer.Write((byte)0x00);
                    _writer.Write((byte)0xFF);
                    _writer.Write((ushort)0x00);
                    _writer.Write((byte)0x00);
                }
                else _writer.Write((ushort)0x00);
            }

            if(Head != null)
            {
                _writer.Write(Head.ToArray());
                _writer.Write((byte)0x00); // wont appear on screen unless i do this
            }

            if (this is GameWearable)
            {
                GameWearable o = this as GameWearable;
                _writer.Write(o.isWorn);
            }
            else _writer.Write((byte)0x00);

            if (this is GameDescribed)
            {
                GameDescribed o = this as GameDescribed;
                _writer.Write(o.isBook);
            }
            else _writer.Write((byte)0x00);

            if(this is GameContainer)
            {
                GameContainer o = this as GameContainer;
                _writer.Write((ushort)o.Items.Count);

                foreach(GameEntity e in o.Items)
                {
                    _writer.Write(e.ToByteArray());
                }
            }
            /*
            // do we have a inventory ?

            if (this is GameMobile)
            {
                GameMobile o = this as GameMobile;

                if (o.Inventory != null)
                {

                 //   _writer.Write((ushort)0x01);//(o.Inventory.Count)); // works if it has 00 inventory
                    _writer.Write((byte)0x01);
                    _writer.Write((ushort)0x04);
                    _writer.Write(ServerGlobals.GetNextAvailableID());
                    _writer.Write((ushort)0x00);
                    _writer.Write((byte)0x00);
                    _writer.Write((byte)0xFF);
                    _writer.Write((ushort)0x00);
                    _writer.Write((byte)0x00);
                }
            }
            */
/*
if (this is GameOpenable)
{
GameOpenable o = this as GameOpenable;
_writer.Write(o.isOpen);
}

if(this is GameSwitch)
{
GameSwitch o = this as GameSwitch;
_writer.Write(o.SwitchState);
}

byte lockState = 0;
_writer.Write(lockState);

byte sitState = 0;
_writer.Write(sitState);

_writer.Write(CanTalk);

_writer.Write(IsInvisible);

byte combatState = 0;
_writer.Write(combatState);

if(this is GameMobile)
{
// _writer.Write((ushort)0x00);
// _writer.Write((byte)0xFF);
}
_stream.Position = 0;
return _stream;
}
*/
#endregion