using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stegonograpy.Classes
{
    class BitOperations
    {
        public static byte setLeastSignificantBitToOne(byte bajt)
        {
            return (byte)(bajt | 1);
        }

        public static byte setLeastSignificantBitToZero(byte bajt)
        {
            return (byte)(bajt & ~1);
        }

        public static byte setBit(byte b, int bitNumber, bool bit)
        {
            if (bit == true)
            {
                return (byte)(b | 1 << bitNumber);
            }
            else
            {
                return (byte)(b & ~(1 << bitNumber));
            }
        }

        public static bool getBit(byte b, int bitNumber)
        {
            return (b & (1 << bitNumber)) != 0;
        }
    }
}
