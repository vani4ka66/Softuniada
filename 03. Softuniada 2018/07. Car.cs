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

            int[] volumes =
                Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int initial = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int maxPossibleVolume = FindMaxVolume(volumes, initial, max);

            Console.WriteLine(maxPossibleVolume);
        }

        private static int FindMaxVolume(int[] volumes, int initial, int max)
        {
            bool[,] matrix = new bool[volumes.Length + 1, max + 1];
            matrix[0, initial] = true;

            for (int row = 1; row <= volumes.Length; row++)
            {
                int element = volumes[row - 1];
                bool breakCondition = true;

                for (int col = 0; col <= max; col++)
                {
                    if (!matrix[row - 1, col])
                    {
                        continue;
                    }
                    breakCondition = false;

                    int addedVolume = col + element;
                    int subtracted = col - element;

                    if (addedVolume <= max)
                    {
                        matrix[row, addedVolume] = true;
                    }

                    if (subtracted >= 0)
                    {
                        matrix[row, subtracted] = true;
                    }
                }
                
                if (breakCondition)
                {
                    return -1;
                }
            }

            return FindRightMostEndVolumes(matrix); ;
        }

        private static int FindRightMostEndVolumes(bool[,] matrix)
        {
            for (int i = matrix.GetLength(1) - 1; i >= 0; i--)
            {
                if (matrix[matrix.GetLength(0) - 1, i])
                {
                    return i;
                }

            }
            return -1;

        }
    }
}

