using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softuniada2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', n*2) + new string('*', n) + new string('.', 2*n));

            int count = 1;
            int subtract = 2;
            for (int i = 0; i < n/2; i++)
            {
              
                Console.WriteLine(new string('.', 2*n - subtract) + new string('*', count) + new string('+', n+2+(i*2)) + new string('*', count) + new string('.', 2*n - subtract));
                count++;
                subtract += 2;
            }

            int m = 0;
            int res = 5*n;
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine(new string('.', n-1-m) + new string('*', 2) + new string('=', res-4-(2*(n-1-m))) + new string('*', 2) + new string('.', n - 1 - m));
                m++;
            }

            int result = 5*n - 16 - n;
            Console.WriteLine(new string('.', n/2) + "**" + new string('~', result/2)+ "HAPPY EASTER" + new string('~', result/2) + "**" + new string('.', n/2));

            int s = 0;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('.', n/2 +s) + new string('*', 2) + new string('=', res - 4 - (2 * (n/2 + s))) + new string('*', 2) + new string('.', n/2 + s));
                m--;
                s++;
            }

            subtract = 0;
            for (int i = 0; i < n / 2; i++)
            {

                Console.WriteLine(new string('.', n + subtract) + new string('*', count - 1) + new string('+', 2*n - i*2) + new string('*', count - 1) + new string('.', n + subtract));
                count--;
                subtract += 2;
            }

            Console.WriteLine(new string('.', n * 2) + new string('*', n) + new string('.', 2 * n));

        }
    }
}
