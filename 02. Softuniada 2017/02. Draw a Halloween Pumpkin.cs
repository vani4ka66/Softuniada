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
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', n - 1) + "_/_" + new string('.', n - 1));
            Console.WriteLine("/" + new string('.', n - 2) + "^,^" + new string('.', n - 2) + "\\");
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("|" + new string('.', n * 2 - 1) + ("|"));
            }

            Console.WriteLine("\\" + new string('.', n - 2) + "\\_/" + new string('.', n - 2) + "/");
        }
    }
}


