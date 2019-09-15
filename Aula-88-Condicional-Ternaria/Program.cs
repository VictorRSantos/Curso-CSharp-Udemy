using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_88_Condicional_Ternaria
{
    class Program
    {
        static void Main(string[] args)
        {

            //Condicional ternária

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
           

            Console.WriteLine(desconto);

        }
    }
}
