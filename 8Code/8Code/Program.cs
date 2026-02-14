using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o salário atual: ");
        double salario = double.Parse(Console.ReadLine());

        Console.Write("Digite o código do cargo: ");
        int codigo = int.Parse(Console.ReadLine());

        string cargo;
        double percentual;

        if (codigo == 101)
        {
            cargo = "Administrador";
            percentual = 0.80 / 100;
        }
        else if (codigo == 102)
        {
            cargo = "Engenheiro";
            percentual = 0.65 / 100;
        }
        else if (codigo == 103)
        {
            cargo = "Médico";
            percentual = 0.60 / 100;
        }
        else
        {
            cargo = "Outro cargo";
            percentual = 0.55 / 100;
        }

        double aumento = salario * percentual;
        double novoSalario = salario + aumento;

        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Salário antigo: R$ " + salario);
        Console.WriteLine("Novo salário: R$ " + novoSalario);
        Console.WriteLine("Diferença: R$ " + aumento);
    }
}
