//-----------------------------------------------------------------------
// <copyright file="PrimeFactors.cs" company="bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used to find prime factors of a given number
    /// </summary>
    public class PrimeFactor
     {
        /// <summary>
        /// Primes the factors.
        /// </summary>
        public void Prime_Factors()
        {
            Console.WriteLine("enter number to find prime factors");
            int num = Utility.GetInt();
            for (int i = 1; i <= num; i++)
            {
                int c = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }

                if (c == 2)
                {
                    while (num % i == 0)
                    {
                        Console.WriteLine(i);
                        num /= i;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
