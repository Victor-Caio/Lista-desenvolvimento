using System;

class Program
{
    static void Main()
    {
        int maior = 0;

        for (int i = 1; i <= 15; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > maior)
            {
                maior = numero;
            }
        }

        Console.WriteLine($"\nO maior número digitado foi: {maior}");
    }
}
