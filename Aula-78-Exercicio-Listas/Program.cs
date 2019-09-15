using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_78_Exercicio_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos empregados você quer registrar? ");
            int registro = int.Parse(Console.ReadLine());


            List<Empregado> list = new List<Empregado>();



            for (int i = 1; i <= registro; i++)
            {

                Console.WriteLine($"Empregado - {i}");

                Console.Write("Id: ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string Nome = Console.ReadLine();
                Console.Write("Salario: ");
                double Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Empregado(Id, Nome, Salario));

                Console.WriteLine("");

            }

            Console.Write("Digite o Id do empregado que deseja aumentar o salario: ");
            int pesquisaId = int.Parse(Console.ReadLine());


            Empregado empregado = list.Find(x => x.Id == pesquisaId);


            if (empregado != null)
            {
                Console.Write("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                empregado.incrementaSalario(porcentagem);

            }
            else
            {

                Console.WriteLine("Essa Id não existe!");

            }

            Console.WriteLine("");

            Console.WriteLine("Lista de atualização de empregados");


            foreach (var obj in list)
            {
                Console.WriteLine(obj);

            }


            


        }
    }
}
