using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[input[0], input[1]];

            for (int row = 0; row < input[0]; row++)
            {
                string[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            string inputP = Console.ReadLine();
            while (inputP != "END")
            {
                string[] inputArray = inputP.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (inputArray[0] == "swap" && ValidationMatrix(int.Parse(inputArray[1]), input[0]) &&
                    ValidationMatrix(int.Parse(inputArray[2]), input[1]) &&
                    ValidationMatrix(int.Parse(inputArray[3]), input[0]) &&
                    ValidationMatrix(int.Parse(inputArray[4]), input[1]))
                {
                    string PositionA1 = inputArray[1];
                    string PositionA2 = inputArray[2];
                    string PositionB1 = inputArray[3];
                    string PositionB2 = inputArray[4];
                    string positionMatrixA = matrix[int.Parse(PositionA1), int.Parse(PositionA2)];
                    matrix[int.Parse(PositionA1), int.Parse(PositionA2)] = matrix[int.Parse(PositionB1), int.Parse(PositionB2)];
                    matrix[int.Parse(PositionB1), int.Parse(PositionB2)] = positionMatrixA; // matrix[int.Parse(PositionA1), int.Parse(PositionA2)];

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col]+" ");
                        }

                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                inputP = Console.ReadLine();
            }

            static bool ValidationMatrix(int postion, int sizeMatrix)
            {
                if (postion >= 0 && postion < sizeMatrix)
                {
                    return true;
                }
                return false;
            }
        }

    }
}
