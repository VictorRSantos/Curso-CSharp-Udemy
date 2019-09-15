using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_71_Exercicio_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Pensao[] vect = new Pensao[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

           

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Aluguel #{i + 1}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Pensao(name, email);

                             

            }


            Console.WriteLine("");
            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i  + ": " + vect[i]);

                }

            }




        }
    }
}
