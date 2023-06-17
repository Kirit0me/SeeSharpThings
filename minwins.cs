using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Kurukuru
{
    internal class Program
    {
        static int minwins(int points, int matches)
        {
 
            int required_win_points = points-matches;

            int minimumWins = required_win_points / 2;
            return minimumWins;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of points required to qualify: ");
            int X = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of matches: ");
            int Y = int.Parse(Console.ReadLine());

            int mw = minwins(X, Y);
            Console.WriteLine("The minimum number of wins required to qualify is {0}", mw);
        }


    }
}