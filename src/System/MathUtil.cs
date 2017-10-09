using System;
using System.Security;
using System.Runtime.InteropServices;

namespace SFML.System
{
    ////////////////////////////////////////////////////////////
    /// <summary>
    /// Utility class for generic math operations
    /// </summary>
    ////////////////////////////////////////////////////////////
    public static class MathUtil
    {
        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        /// <param name="_fA">Start value for T = 0</param>
        /// <param name="_fB">End value for T = 1</param>
        /// <param name="_fT">Value between 0 and 1</param>
        /// <returns>The interpolated float result between the two float values.</returns>
        public static float Lerp(float _fA, float _fB, float _fT)
        {
            return _fA * (1 - _fT) + _fB * _fT;
        }
    }
}
