using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmDecoder.Encryption
{
    public class XoRKey
    {
        #region Fields
        /// <summary>
        /// Our Multiplier
        /// </summary>
        private const int MULTIPLIER = 98543;
        /// <summary>
        /// Set to the above value
        /// </summary>
        public Int32 Multiplier { get; set; }
        /// <summary>
        /// Our 4 byte Xor key
        /// </summary>
        public byte[] Key { get; set; }

        #endregion
        #region Constructors
        /// <summary>
        /// Our 4 byte Xor key
        /// </summary>
        /// <param name="key">4 bytes only</param>
        public XoRKey(byte[] key)
        {
            this.Key = key;
            this.Multiplier = MULTIPLIER;
        }
        #endregion
    }
}
