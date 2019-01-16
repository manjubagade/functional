//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used for declaring repeated task
    /// </summary>
    class Utility
    {
        /// <summary>
        /// Gets the integer will return the integer value
        /// </summary>
        /// <returns>integer required by the programmer</returns>
        public static int GetInt()
        {
            ////converting string to integer
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }

        /// <summary>
        /// get double will return the double value
        /// </summary>
        /// <returns>returns double value required by the programmer</returns>
        public static Double GetDouble()
        {
            double d = Convert.ToDouble(Console.ReadLine());
            return d;
        }

        public static string GetString()
        {
            string s = Convert.ToString(Console.ReadKey());
            return s;
        }
    }  
}
