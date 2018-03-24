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
            string first = Console.ReadLine();
            int min1 = 0;
            int hour1 = 0;
            int min2 = 0;
            int hour2 = 0;
            int day1 = 0;
            int day2 = 0;

            if (first.Contains("::"))
            {
                string[] input = first.Split(new string[] { "::" }, StringSplitOptions.RemoveEmptyEntries);
                day1 = int.Parse(input[0]);
                string[] rest1 = input[1].Split(':');
                min1 = int.Parse(rest1[1]);
                hour1 = int.Parse(rest1[0]);
            }
            else
            {
                string[] input = first.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                min1 = int.Parse(input[1]);
                hour1 = int.Parse(input[0]);
            }

            string second = Console.ReadLine();

            if (second.Contains("::"))
            {
                string[] input = second.Split(new string[] { "::" }, StringSplitOptions.RemoveEmptyEntries);
                day2 = int.Parse(input[0]);
                string[] rest2 = input[1].Split(':');
                min2 = int.Parse(rest2[1]);
                hour2 = int.Parse(rest2[0]);
            }
            else
            {
                string[] input = second.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                min2 = int.Parse(input[1]);
                hour2 = int.Parse(input[0]);
            }

            var minPlus = (min1 + min2) / 60;
            var minResult = (min1 + min2) - (60 * minPlus);

            var hoursPlus = (hour1 + hour2 + minPlus) / 24;
            var hourResult = (hour1 + hour2 + minPlus) - (24 * hoursPlus);

            var days = hoursPlus + day1 + day2;

            if (days != 0)
            {
                string min = minResult.ToString();
                if (minResult.ToString().Length == 1)
                {
                    min = "0" + minResult;
                }
                Console.WriteLine(days + "::" + hourResult + ":" + min);

            }
            else
            {
                string min = minResult.ToString();
                if (minResult.ToString().Length == 1)
                {
                    min = "0" + minResult;
                }
                Console.WriteLine(hourResult + ":" + min);
            }

        }


    }
}


