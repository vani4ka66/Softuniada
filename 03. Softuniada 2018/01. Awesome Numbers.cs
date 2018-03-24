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
            int favorite = int.Parse(Console.ReadLine());

            bool isOdd = false;
            bool isNegative = false;
            bool isDivide = false;

            if (n % 2 != 0)
            {
                isOdd = true;
            }
            if (n < 0)
            {
                isNegative = true;
            }
            if (n % favorite == 0)
            {
                isDivide = true;
            }

            if (isOdd && isNegative && isDivide)
            {
                Console.WriteLine("super special awesome");
            }
            else if (isOdd && isNegative)
            {
                Console.WriteLine("super awesome");
            }
            else if (isOdd && isDivide)
            {
                Console.WriteLine("super awesome");
            }
            else if (isNegative && isDivide)
            {
                Console.WriteLine("super awesome");
            }
            else if (isDivide || isNegative || isOdd)
            {
                Console.WriteLine("awesome");
            }
            else
            {
                Console.WriteLine("boring");
            }
        }
    }
}

