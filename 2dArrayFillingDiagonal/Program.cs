/// <summary>
///     This is Exercise 1 from page 45 (The Matrix section) of
///     the Programming = ++ Algorithms book by Preslav Nakov and Panayot Dobrikov
/// </summary>
/// <see href="https://programirane.org/"/>


namespace _2dArrayFillingDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n = 5;
            uint[,] matrix = new uint[n, n];
            FillMatrix(matrix, n);
            PrintMatrix(matrix, n);
        }
        // This method is not part of the exercise but it is used for testing purposes
        static void PrintMatrix(uint[,] matrix, uint n)
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
        static void FillMatrix(uint[,] matrix, uint n)
        {
            uint counter = 1;
            // 0 diagonal
            for (uint i = 0; i < n; i++)
            {
                matrix[i, i] = 0;
            }
            // below diagonal
            uint r = 1;
            for (int col = 0; col < n; col++)
            {
                for (uint row = r; row < n; row++)
                {
                    matrix[row, col] = counter++;
                }
                r++;
            }
            // above diagonal
            r = n - 2;
            for (uint col = n - 1; col > 0; col--)
            {
                for (uint row = r; row < n; row--)
                {
                    matrix[row, col] = counter++;
                }
                r--;
            }
        }
    }
}
