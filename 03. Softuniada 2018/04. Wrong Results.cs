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
            int size = int.Parse(Console.ReadLine());

            string[,,] cube = new string[size, size, size];
            int count = 0;

            FillCube(size, cube);

            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int matrixIndex = tokens[0];
            int rowIndex = tokens[1];
            int colIndex = tokens[2];

            string wrong = cube[rowIndex, matrixIndex, colIndex];

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        string current = cube[j, i, k];
                        if (current == wrong)
                        {
                            count++;
                            string behind = "0";
                            string up ="0";
                            string down = "0";
                            string right = "0";
                            string left = "0";
                            string front = "0";

                            if (j + 1 < size)
                            {
                                down = cube[j + 1, i, k];
                                if (down == wrong)
                                {
                                    down = "0";
                                }
                            }
                            if (j - 1 >= 0)
                            {
                                up = cube[j - 1, i, k];
                                if (up == wrong)
                                {
                                    up = "0";
                                }
                            }
                            if (i + 1 < size)
                            {
                                behind = cube[j, i + 1, k];
                                if (behind == wrong)
                                {
                                    behind = "0";
                                }
                            }
                            if (i - 1 >= 0)
                            {
                                front = cube[j, i - 1, k];
                                if (front == wrong)
                                {
                                    front = "0";
                                }
                            }
                            if (k + 1 < size)
                            {
                                right = cube[j, i, k + 1];
                                if (right == wrong)
                                {
                                    right = "0";
                                }
                            }
                            if (k - 1 >= 0)
                            {
                                left = cube[j, i, k - 1];
                                if (left == wrong)
                                {
                                    left = "0";
                                }
                            }
                            
                            int sum  = int.Parse(up) + int.Parse(down) + int.Parse(left) + int.Parse(right) + int.Parse(behind) + int.Parse(front);
                            list.Enqueue(sum.ToString());
                        } 
                    }
                }
            }
            Console.WriteLine("Wrong values found and replaced: " + count);
            
            List<string> result = new List<string>();
           
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        if (cube[j, i, k] == wrong)
                        {
                            result.Add(list.Dequeue());
                        }
                        else
                        {

                            result.Add(cube[j, i, k]);
                        }
                    }
                }
            }
            Console.Write(result[0] + " ");
            for (int i = 1; i < result.Count - 1; i++)
            {
                if (i % size == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(result[i] + " ");
            }
            Console.WriteLine(result[result.Count-1]);
        }



        private static void FillCube(int size, string[,,] cube)
        {
            for (int i = 0; i < size; i++)
            {
                string[] layers = Console.ReadLine().Split(new[] { '|' }).Select(x => x.Trim()).ToArray();

                for (int j = 0; j < layers.Length; j++)
                {
                    string[] symbols = layers[j].Split();

                    for (int k = 0; k < symbols.Length; k++)
                    {
                        cube[i, j, k] = symbols[k];
                    }
                }
            }
        }
    }
}
