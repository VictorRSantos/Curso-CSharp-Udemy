using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_51_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
                       

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Produto p = new Produto(nome, preco, quantidade);

            
            
            Console.WriteLine("");
            Console.WriteLine("Dados do produto: " + p);


            Console.WriteLine("Digite um número do produto para ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);


            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + p );


            Console.WriteLine("");
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);


            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + p);



        }
    }
}

