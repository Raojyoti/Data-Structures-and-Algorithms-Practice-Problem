using System;

namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int i, j;
            Console.WriteLine("Prime Numbers between 1 to 1000 are : ");
            Console.WriteLine("--------------------------------------------");
            for (i = 2; i <= 1000; i++)
            {
                for (j = 2; j <= 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + "\t" );
                }
                isPrime = true;
            }
            Console.WriteLine("\n");
        }
    }
}
