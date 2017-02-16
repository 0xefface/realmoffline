using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace RealmOffline.Core
{
    public class GameItem : GameEntity
    {

        #region ItemTest
        // Ok
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct InternalItem
        {
            public byte Begin;
            public short GraphicID;
            public int GameID;
            public short Color;
            public byte UsesBaseName;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
            public byte[] Enchants; // just using 0x20 for identify now
            public byte EndEnchants;
            public byte MoneyType;
            public byte IsInRoom;
            public byte IsEquipable;
            public byte IsEquiped;
            public byte IsBook;
            public short ContainedItems; // must be a container
            public byte IsLocked;
            public byte IsSittingOn;
            public byte CanTalk;
            public byte IsInvisible;
            public byte IsInCombat;

            public void Init(short graphicID, bool isEquipable)
            {
                Begin = 0x01;
                GraphicID = graphicID;
                GameID = (int)ServerGlobals.GetNextAvailableID();
                Color = 0x4A;
                // add id ?
                Enchants = new byte[] { 0x20 };
                EndEnchants = 0xFF;
                IsEquipable = (byte)(isEquipable ? 0x01 : 0x00);

            }
        }
        #endregion
        #region Tools
        public static byte[] StructureToByteArray(object obj)
        {
            int len = Marshal.SizeOf(obj);

            byte[] arr = new byte[len];

            IntPtr ptr = Marshal.AllocHGlobal(len);

            Marshal.StructureToPtr(obj, ptr, true);

            Marshal.Copy(ptr, arr, 0, len);

            Marshal.FreeHGlobal(ptr);

            return arr;
        }
        #endregion
    }
}
