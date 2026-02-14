using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, X;
            Console.WriteLine("Digite um numero");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2) 
            {
                X = n1;
                n2 = n1;
                n1 = X;
            }

            Console.WriteLine("\nnumeros impares entre eles\n");
            for (int i = 0; i <= n2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}