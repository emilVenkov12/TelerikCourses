using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitHelper
{
    public class BitwiseOperation
    {
        /// <summary>
        /// Check if the integer is even or odd.
        /// </summary>
        /// <param name="number">number to be check</param>
        /// <returns>true if is even and false if isn't</returns>
        static bool isEven(long number)
        {
            if ((number & 1) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Test if the n-th bit is set.
        /// </summary>
        /// <param name="number">number, which bit want to check</param>
        /// <param name="bitPos">position of the bit</param>
        /// <returns>True if bit is equal to 1 or false if isn't</returns>
        static bool isGivenBitSet(long number, int bitPos)
        {
            if ((number & (1L << bitPos)) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Set the n-th bit.
        /// </summary>
        /// <param name="number">number, which bit want to set</param>
        /// <param name="bitPos">position of the bit</param>
        /// <returns>New number with given bit set</returns>
        static long SetGivenBit(long number, int bitPos)
        {
            return (number | (1L << bitPos));
        }

        /// <summary>
        /// Unset the n-th bit.
        /// </summary>
        /// <param name="number">number, which bit to unset.</param>
        /// <param name="bitPos">position of the bit</param>
        /// <returns>New number, with given bit unseted.</returns>
        static long UnsetGivenBit(long number, int bitPos)
        {
            return (number & ~(1L << bitPos));
        }

        /// <summary>
        /// Toggle n-th bit.
        /// </summary>
        /// <param name="number">number, which bit want to toggle.</param>
        /// <param name="bitPos">position of the bit.</param>
        /// <returns>New number with, given bit toggled</returns>
        static long ToggleGivenBit(long number, int bitPos)
        {
            return (number ^ (1L << bitPos));
        }

        /// <summary>
        /// Turn off the rightmost 1-bit.
        /// </summary>
        /// <param name="number">number, which rightmost 1-bit to turn off.</param>
        /// <returns>New number with rightmost 1-bit turn off</returns>
        static long TurnOffRightmostFirstBit(long number)
        {
            return (number & (number - 1));
        }

        /// <summary>
        /// Isolate the rightmost 1-bit.
        /// </summary>
        /// <param name="number">number, which rightmost 1-bit to isolate</param>
        /// <returns>New number, with rightmost 1-bit isolate</returns>
        static long IsolateRightmostFirstBit(long number)
        {
            return (number & (-number));
        }
    }
}
