/// <summary>
///     This is Exercise 2 from page 45 (Chapter 1, The Matrix section) of
///     the Programming = ++ Algorithms book by Preslav Nakov and Panayot Dobrikov
/// </summary>
/// <see href="https://programirane.org/"/>

namespace _2dArrayFillingSnake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the matrix: ");
            int n = int.Parse(Console.ReadLine());
            uint[,] matrix = new uint[n, n];
            FillMatrix(matrix, n);
            PrintMatrix(matrix, n);
        }
        // This method is not part of the exercise but it is used for testing purposes
        static void PrintMatrix(uint[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }
        }
        static void FillMatrix(uint[,] matrix, int n)
        {
            int steps = n;
            uint count = 1;
            int currRow = 0;
            int currCol = 0;
            while (steps > 0)
            {
                //down
                for(int row = currRow, v = 0; v < steps; row++, v++)
                {
                    currRow = row;
                    matrix[currRow, currCol] = count++;
                }
                // right
                currCol++;
                steps--;
                for(int col = currCol, v = 0; v < steps; col++, v++)
                {
                    currCol = col;
                    matrix[currRow, currCol] = count++;
                }
                // up
                currRow--;
                for (int row = currRow, v = 0; v < steps; row--, v++)
                {
                    currRow = row;
                    matrix[currRow, currCol] = count++;
                }
                // left
                currCol--;
                steps--;
                for (int col = currCol, v = 0; v < steps; col--, v++)
                {
                    currCol = col;
                    matrix[currRow, currCol] = count++;
                }
                currRow++;
            }
        }
    }
}
