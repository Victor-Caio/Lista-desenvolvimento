using System;

class Program
{
    static void Main()
    {
        int pares = 0;
        int impares = 0;
        int positivos = 0;
        int negativos = 0;

        string resposta = "N";

        while (resposta != "S")
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                pares++;
            else
                impares++;

            if (numero > 0)
                positivos++;
            else if (numero < 0)
                negativos++;

            Console.Write("Deseja encerrar o programa? (S/N): ");
            resposta = Console.ReadLine().ToUpper();
        }

        Console.WriteLine("\nResultado final:");
        Console.WriteLine("Quantidade de números pares: " + pares);
        Console.WriteLine("Quantidade de números ímpares: " + impares);
        Console.WriteLine("Quantidade de números positivos: " + positivos);
        Console.WriteLine("Quantidade de números negativos: " + negativos);
    }
}
