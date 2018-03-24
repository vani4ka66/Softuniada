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
            StringBuilder input = new StringBuilder(Console.ReadLine());

            bool isMatch = false;
            int count = 0;

            while (true)
            {
                if (input.Length == 0)
                {
                    break;
                }
                isMatch = false;
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i] == input[i + 1])
                    {
                        input.Remove(i, 2);
                        i = i + 1;
                        count++;
                        isMatch = true;
                    }
                }
                if (!isMatch)
                {
                    break;
                }
            }

            if (input.Length == 0)
            {
                Console.WriteLine("Empty String");
                Console.WriteLine("{0} operations", count);
            }
            else
            {
                Console.WriteLine(string.Join("", input));
                Console.WriteLine("{0} operations", count);
            }

        }
    }
}


