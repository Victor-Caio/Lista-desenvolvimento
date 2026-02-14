using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros pares do 211 até 250");
            for (int i = 211; i <= 250; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}