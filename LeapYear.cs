//-----------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used to find whether the given year is a leap year or not
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// Leap year this instance.
        /// </summary>
        public void Leapyear()
        {
            Console.WriteLine("enter year with four digits");
            string year = Console.ReadLine();
            if (year.Length == 4)
            {
                int num = Convert.ToInt32(year);
                if ((num % 4 == 0) && (num % 100 != 0) || (num % 400 == 0))
                {
                    Console.WriteLine(num + " is a leap year");
                }
                else
                {
                    Console.WriteLine(num + " is not a leap year");
                }
            }
            else
            {
                Console.WriteLine("enter correct date");
            }

            Console.ReadLine();
        }
    }
}
