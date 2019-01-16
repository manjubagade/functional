//-----------------------------------------------------------------------
// <copyright file="HarmonicNum.cs" company="Brigdelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used to generate harmonic numbers
    /// </summary>
    public class Harmonicnum
    {
        /// <summary>
        /// Harmonics this instance.
        /// </summary>
        public void Harmonic()
        {
            Console.WriteLine("enter the Nth harmonic number");
            int n = Utility.GetInt();
            float num = 0;
            for (int i = 1; i <= n; i++)
            {
                num = num + (float)(1.0 / i);
            }
            Console.WriteLine(" the Nth harmonic number is " + num);
            Console.ReadLine();
        }
    }
}
