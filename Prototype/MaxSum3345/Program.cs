using System;
using System.Linq;

namespace MaxSum3345
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = (Console.ReadLine()).Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[input[0], input[1]];
            int[,] outMatrix = new int[3, 3];
            int count = int.MinValue;
            for (int row = 0; row < input[0]; row++)
            {
                int[] currentRow = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            for (int i = 0; i < input[0] - 2; i++)
            {
                for (int j = 0; j < input[1] - 2; j++)
                {
                    int s = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                         matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                         matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                  
                    if (s>count)
                    {
                        count=s;
                        outMatrix[0, 0] = matrix[i, j];
                        outMatrix[0, 1] = matrix[i, j + 1];
                        outMatrix[0, 2] = matrix[i, j + 2];
                        outMatrix[1, 0] = matrix[i+1, j ];
                        outMatrix[1, 1] = matrix[i+1, j + 1];
                        outMatrix[1, 2] = matrix[i+1, j + 2];
                        outMatrix[2, 0] = matrix[i+2, j];
                        outMatrix[2, 1] = matrix[i+2, j + 1];
                        outMatrix[2, 2] = matrix[i+2, j + 2];
                            }
                }
            }
            Console.WriteLine($"Sum = {count}");

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(outMatrix[row, col]+" ");
                }

                Console.WriteLine();
            }
        }
    }
}
