namespace PrimeFactorization
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i, j, how;
            Console.Write($"{n} = ");
            i = 1;
            while(n != 1)
            {
                i++;
                how = 0;
                while(n % i == 0)
                {
                    how++;
                    n /= i;
                }
                for(j = 0; j < how; j++)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
