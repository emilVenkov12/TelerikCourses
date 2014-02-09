using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitHelper
{
    class BitConversions
    {
        static char[] ToBinaryCharArray(long number, int bitsCount)  
        {
            if (bitsCount > 64 || bitsCount <= 0)
            {
                throw new ArgumentException("Bits count need to be bigger than zero and smaller than 65");
            }
            return Convert.ToString(number, 2).PadLeft(bitsCount, '0').ToCharArray();
        }

        static char[] ToBinaryCharArray(int number, int bitsCount)
        {
            if (bitsCount > 32 || bitsCount <= 0)
            {
                throw new ArgumentException("Bits count need to be bigger than zero and smaller than 33");
            }
            return Convert.ToString(number, 2).PadLeft(bitsCount, '0').ToCharArray();
        }
    }
}
