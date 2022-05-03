using System;
using System.Collections.Generic;
using System.Text;

namespace Avalara.SDK.Auth
{
    /// <summary>
    /// Extension method(s) for Auth classes
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Check is string is NULL / empty / spaces
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNullorEmpty(this string str)
        {
            return string.IsNullOrEmpty(str) || str.Trim().Length == 0;
        }
    }
}
