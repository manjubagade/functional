//-----------------------------------------------------------------------
// <copyright file="PowerOf2.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used to find the powers of 2
    /// </summary>
    public class PowerOf2
    {
        /// <summary>
        /// Powers the of 2.
        /// </summary>
        public void PowersOf2()
        {
            Console.WriteLine("ENTER THE NUM TO POWER OF 2");
            //// it takes the input of power 2
            int num = Utility.GetInt();
            if (num == 0)
            {
                Console.WriteLine(Math.Pow(2, 0));
            }
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
            Console.ReadLine();
        }
      }
  }
