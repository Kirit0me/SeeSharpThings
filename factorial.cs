using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Kurukuru
{
    internal class Program
    {
        static int countzeros(int n)
        {
            int count = 0;
            while (n >= 5)
            {
                n /= 5;
                count += n;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int zeroes = countzeros(n);
            Console.WriteLine("Number of trailing zeroes in {0} factorial: {1}", n, zeroes);
        }
    }
}