using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_55_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome= "TV";

            p.Preco = 400.00;

            p.SetPreco(800.00);
           

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.GetPreco());
           


        }
    }
}

