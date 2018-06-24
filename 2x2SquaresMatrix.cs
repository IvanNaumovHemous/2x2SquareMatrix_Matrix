using System;
using System.Linq;

namespace _2x2SquaresMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            char[,] matrix = GetFilledMatrix(input);

            int numberOfSquares = GetSquares(matrix);
            Console.WriteLine(numberOfSquares);
        }

        private static int GetSquares(char[,] matrix)
        {
            int squares = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    bool IsSquare = matrix[i, j] == matrix[i, j + 1] &&
                                    matrix[i, j] == matrix[i + 1, j] &&
                                    matrix[i, j] == matrix[i + 1, j + 1];

                    if (IsSquare)
                    {
                        squares++;
                    }
                }
            }

            return squares;
        }

        private static char[,] GetFilledMatrix(int[] temp)
        {
            var rows = temp[0];
            var columns = temp[1];
            var matrix = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            return matrix;
        }
    }
}
