using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmDecoder.Encryption
{
    public static class Xor
    {
        private const short ENCODE_VAL1 = 0x39;
        private const short ENCODE_VAL2 = 0x46;
        private const short ENCODE_VAL3 = 0x0c;
        private const short ENCODE_VAL4 = 0x30;

        public static byte[] decrypt(byte[] encrypted_text, XoRKey Key)
        {
            byte[] xor_array = new byte[4];
            byte[] decrypted_text = new byte[encrypted_text.Length];
            Int32 xa_int;
            try
            {
                xor_array = Key.Key;
                for (int i = 0; i < encrypted_text.Length; i += 4)
                {
                    xa_int = BitConverter.ToInt32(xor_array, 0);
                    xa_int *= Key.Multiplier;
                    xa_int++;

                    xor_array = BitConverter.GetBytes(xa_int);

                    for (int j = 0; j < 4 && (i + j < encrypted_text.Length); j++)
                        decrypted_text[i + j] = Convert.ToByte(encrypted_text[i + j] ^ xor_array[j]);
                }

                Key.Key = xor_array;
                return decrypted_text;
            }
            catch (Exception e)
            {
                throw new Exception("Exception in decrypt function: " + e.Message);
            }
        }
        public static byte[] encode(byte[] text_to_encode, byte byte1, byte byte2)
        {
            try
            {
                byte[] encoded_text = new byte[text_to_encode.Length];
                byte a1, a2, a3, a4;
                byte b1 = byte1, b2 = byte2;

                for (int i = 0; i < text_to_encode.Length; i = i + 4)
                {
                    a1 = text_to_encode[i];
                    a2 = text_to_encode[i + 1];
                    a3 = text_to_encode[i + 2];
                    a4 = text_to_encode[i + 3];

                    a1 = (byte)((a1 + b1) - ENCODE_VAL1);
                    a2 = (byte)((a2 - b2) + ENCODE_VAL2);
                    a3 = (byte)((a3 - b1) + ENCODE_VAL3);
                    a4 = (byte)((a4 + b2) - ENCODE_VAL4);

                    encoded_text[i] = (byte)a1;
                    encoded_text[i + 1] = (byte)a2;
                    encoded_text[i + 2] = (byte)a3;
                    encoded_text[i + 3] = (byte)a4;
                }

                return encoded_text;
            }
            catch (Exception e)
            {
                throw new Exception("Exception in encode function: " + e.Message);
            }
        }

        public static byte[] decode(byte[] text_to_decode, byte byte1, byte byte2)
        {
            try
            {
                byte[] decoded_text = new byte[text_to_decode.Length];
                byte a1, a2, a3, a4;
                byte b1 = byte1, b2 = byte2;

                for (int i = 0; i < text_to_decode.Length; i = i + 4)
                {
                    a1 = text_to_decode[i];
                    a2 = text_to_decode[i + 1];
                    a3 = text_to_decode[i + 2];
                    a4 = text_to_decode[i + 3];

                    a1 = (byte)((a1 - b1) + ENCODE_VAL1);
                    a2 = (byte)((a2 + b2) - ENCODE_VAL2);
                    a3 = (byte)((a3 + b1) - ENCODE_VAL3);
                    a4 = (byte)((a4 - b2) + ENCODE_VAL4);

                    decoded_text[i] = (byte)a1;
                    decoded_text[i + 1] = (byte)a2;
                    decoded_text[i + 2] = (byte)a3;
                    decoded_text[i + 3] = (byte)a4;
                }

                return decoded_text;
            }
            catch (Exception e)
            {
                throw new Exception("Exception in encode function: " + e.Message);
            }
        }

        public static byte[] generateCRC(byte[] stream, byte[] xor_key)
        {
            byte[] crc = new byte[stream.Length];

            try
            {
                for (int i = 0; i < stream.Length; i += 4)
                {
                    for (int j = 0; j < 4 && (i + j < stream.Length); j++)
                        xor_key[j] = Convert.ToByte(stream[i + j] ^ xor_key[j]);
                }

                return xor_key;
            }
            catch (Exception e)
            {
                throw new Exception("Exception in generateCRC function: " + e.Message);
            }
        }
        public static byte[] generateKeyFromCRC(byte[] stream, byte[] xor_key)
        {
           // byte[] crc = new byte[stream.Length];

            try
            {
                for (int i = 0; i < stream.Length; i += 4)
                {
                    for (int j = 0; j < 4 && (i + j < stream.Length); j++)
                        xor_key[j] = Convert.ToByte(stream[i + j] ^ xor_key[j]);
                }

                return xor_key;
            }
            catch (Exception e)
            {
                throw new Exception("Exception in generateCRC function: " + e.Message);
            }
        }
    }
}
