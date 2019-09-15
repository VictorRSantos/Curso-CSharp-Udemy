using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_40_Exercicios_Classe_Objeto_Atributos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome:");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade:");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------");                     
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome:");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade:");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");

            }


            */

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();


            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine($"Salário médio = {mediaSalario}",("F2", CultureInfo.InvariantCulture));

















        }
    }
}
