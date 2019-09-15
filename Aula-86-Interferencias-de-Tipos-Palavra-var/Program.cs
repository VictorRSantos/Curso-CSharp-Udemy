using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_86_Interferencias_de_Tipos_Palavra_var
{
    class Program
    {
        static void Main(string[] args)
        {

            //Var não precisa declara o tipo da variavel

            var x = 10;

            var y = 20.0;

            var z = "Maria";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


        }
    }
}
