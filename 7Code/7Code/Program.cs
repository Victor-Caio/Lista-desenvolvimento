using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do primeiro usuário: ");
            string nome1 = Console.ReadLine();

            Console.Write("Digite o dia do aniversário do primeiro usuário: ");
            int dia1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o mês do aniversário do primeiro usuário: ");
            int mes1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do segundo usuário: ");
            string nome2 = Console.ReadLine();

            Console.Write("Digite o dia do aniversário do segundo usuário: ");
            int dia2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o mês do aniversário do segundo usuário: ");
            int mes2 = int.Parse(Console.ReadLine());

            if (mes1 < mes2 || (mes1 == mes2 && dia1 < dia2))
            {
                Console.WriteLine(nome1 + " faz aniversário primeiro.");
            }
            else if (mes2 < mes1 || (mes1 == mes2 && dia2 < dia1))
            {
                Console.WriteLine(nome2 + " faz aniversário primeiro.");
            }
            else
            {
                Console.WriteLine("Os dois fazem aniversário no mesmo dia.");
            }
        }
    }
}