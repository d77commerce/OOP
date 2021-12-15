using System;
using System.Linq;

namespace _2x2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = (Console.ReadLine()).Split(" ").Select(int.Parse).ToArray();
           string[,] matrix = new string[input[0], input[1]];
            int count = 0;
            for (int row = 0; row < input[0]; row++)
            {
                string[] currentRow = Console.ReadLine().Split();
                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
         
            for (int i = 0; i < input[0]-1; i++)
            {
                for (int j = 0; j < input[1]-1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] &&
                        matrix[i, j] == matrix[i + 1, j + 1] && 
                        matrix[i, j] == matrix[i + 1, j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
