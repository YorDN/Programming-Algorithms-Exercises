namespace IsNumberPrima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your number!");
            uint n = uint.Parse(Console.ReadLine());
            if (IsPrime(n))
            {
                Console.WriteLine("The number is prime!");
            }
            else
            {
                Console.WriteLine("The number is not prime!");
            }

        }
        static bool IsPrime(uint n)
        {
            uint i = 2;
            if (n == 2) return true;
            while(i <= Math.Sqrt(n))
            {
                if(n % i == 0) return false;
                i++;
            }
            return true;
        }
    }
}
