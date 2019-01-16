//-----------------------------------------------------------------------
// <copyright file="Coupon.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used for generate distinct coupon numbers and number of distinct 
    /// </summary>
    class Coupons
    {

        /// <summary>
        /// Coupons the numbers.
        /// </summary>
        public void CouponNum()
        {
            Console.WriteLine("enter the size of coupon");
            int n = Utility.GetInt();
            int count = 0;
            Random r = new Random();
            string dcn = string.Empty;

            for(int i  = 1; i <= n; i++)
            {
                string val = r.Next(0, n) + string.Empty;
                count++;
                if (!dcn.Contains(val))
                {
                    dcn = dcn + val;
                }
                else
                {
                    i--;
                }
            }

            Console.WriteLine("random number  " + count);
            Console.WriteLine(" the distinctCouponNumbers is ");
            foreach (char numbers in dcn)
            {
                Console.WriteLine(numbers);
            }

            Console.ReadLine();
        }
    }
}
