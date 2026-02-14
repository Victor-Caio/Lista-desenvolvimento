using System;

class Program
{
    static void Main()
    {
        string resposta = "N";

        while (resposta != "S")
        {
            Console.Write("Digite o número de horas trabalhadas: ");
            int N = int.Parse(Console.ReadLine());

            float salario;
            float E = 0;

            if (N > 50)
            {
                int horasExcedentes = N - 50;
                E = horasExcedentes * 20;
                salario = (50 * 10) + E;
            }
            else
            {
                salario = N * 10;
                E = 0;
            }

            Console.WriteLine("Salário total: R$ " + salario);
            Console.WriteLine("Salário excedente: R$ " + E);

            Console.Write("Deseja encerrar o programa? (S/N): ");
            resposta = Console.ReadLine().ToUpper();
        }
    }
}
