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
            string[] nums = Console.ReadLine().Split();
            int a = int.Parse(nums[0]);
            int b = int.Parse(nums[1]);
            int c = int.Parse(nums[2]);

            if (a + b + c == 13 ||
                -a + b + c == 13 ||
                a - b + c == 13 ||
                a + b - c == 13 ||
                -a - b + c == 13 ||
                -a + b - c == 13 ||
                a - b - c == 13 ||
                -a - b - c == 13)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
