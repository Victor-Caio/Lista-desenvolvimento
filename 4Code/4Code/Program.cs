using System;

class Program
{
    static void Main()
    {
        int soma = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Digite a {i}ª nota (0 a 10): ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 0 && nota <= 10)
            {
                soma = soma + nota;
            }
            else
            {
                Console.WriteLine("Valor inválido! A nota deve estar entre 0 e 10.");
                i--;
            }
        }

        int media = soma / 10;
        Console.WriteLine($"\nA média das notas é: {media}");
    }
}
