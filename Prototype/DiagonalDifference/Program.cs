using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,]matrix = new int[n,n];
            int sum = 0;
            int sum2 = 0;
            for (int row = 0; row < n; row++)
            {
               int [] currentRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            int row1 = n - 1;
            int col1 = 0;
            for (int i = 0; i < n; i++)
            {
                sum2 += matrix[row1, col1];
                row1--;
                col1++;
            }

            Console.WriteLine(Math.Abs(sum-sum2));
        }
    }
}
