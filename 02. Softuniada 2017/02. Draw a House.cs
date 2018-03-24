using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static string[] arr = new string[4];
        static List<int> divide12 = new List<int>();
        static List<int> divide15 = new List<int>();


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = n - 1;
            int count = 1;

            Console.WriteLine(new string('.', m) + "*" + new string('.', m));

            for (int i = 0; i < n - 2; i++)
            {
                --m;

                Console.WriteLine(new string('.', m) + "*" + new string(' ', count) + "*" + new string('.', m));
                count += 2;
            }
            Console.Write("*");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();

            Console.WriteLine("+" + new string('-', (n * 2) - 3) + "+");

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|" + new string(' ', (n * 2) - 3) + "|");
            }
            Console.WriteLine("+" + new string('-', (n * 2) - 3) + "+");


        }


    }
}


