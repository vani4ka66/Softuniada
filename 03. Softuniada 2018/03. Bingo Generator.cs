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
            string n = Console.ReadLine();

            for (int i = 0; i < n.Length; i++)
            {
                string current = n[i].ToString();
                arr[i] = current;
            }

            Gen(arr);
            Console.Write("Dividing on 12: ");
            Console.WriteLine(string.Join(" ", divide12));
            Console.WriteLine();

            Console.Write("Dividing on 15: ");
            Console.WriteLine(string.Join(" ", divide15));
            Console.WriteLine();

            if (divide12.Count == divide15.Count)
            {
                Console.WriteLine("!!!BINGO!!!");
            }
            else
            {
                Console.WriteLine("NO BINGO!");
            }
        }

        private static void Gen(string[] arr)
        {
            string start = arr[0] + "" + arr[2] + arr[1] + arr[3]; // 1123
            int sum = int.Parse(arr[0] + "" + arr[2]) + int.Parse(arr[1] + "" + arr[3]); //34
            int firstPart = int.Parse(arr[0] + "" + arr[2]); //11
            //int secondPart = int.Parse(arr[1] + "" + arr[3]); //23

            while (true)
            {
                int secondPart = int.Parse(arr[1] + "" + arr[3]); //23
                if (firstPart > sum)
                {
                    break;
                }
                while (true)
                {
                    if (secondPart > sum)
                    {
                        break;
                    }
                    string res = (firstPart + "" + secondPart);
                    int result = int.Parse(res);
                    if (result % 12 == 0)
                    {
                        divide12.Add(result);
                    }
                    if (result % 15 == 0)
                    {
                        divide15.Add(result);
                    }
                    secondPart++;

                }

                firstPart++;
            }
            }
        }
    }


