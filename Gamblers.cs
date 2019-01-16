//-----------------------------------------------------------------------
// <copyright file="Gambler.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used to find wins percentage 
    /// </summary>
    class Gamblers
    {
        /// <summary>
        /// Gambler1s this instance.
        /// </summary>
        public void Gambler1()
        {
            Console.WriteLine("enter the values of stake");
            int stake = Utility.GetInt();
            Console.WriteLine("enter the values of goal");
            int goal = Utility.GetInt();
            Console.WriteLine("enter the values of times");
            int trials = Utility.GetInt();
            int bets = 0;
            int wins = 0;
            int loose = 0;
            Random r = new Random();
            for(int i = 0; i <= trials; i++)
            {
               int cash = stake;
                while(cash > 0 && cash < goal)
                {
                    bets++;
                    if (r.Next(0,2) < 0.5)
                    {
                        cash--;
                    }
                    else
                    {
                        cash++;
                    }
                }
                if(cash==goal)
                {

                    wins++;
                }
                else
                {
                    loose++;
                }
            }
            Console.WriteLine(wins + " wins of " + trials);
            Console.WriteLine(" percentage of games wons " + ((100.0 * wins) / trials));
            Console.WriteLine(" percentage of games loose " + (100.0 * loose) / trials);
            Console.WriteLine(" average # bets " + ((1.0 * bets) / trials));
            Console.ReadLine();
        }
    }
}
