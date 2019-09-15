using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula_45_Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
         
            Console.WriteLine("Entre com a largura e altura do retângulo:");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           
            Console.WriteLine("Área = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));





        }
    }
}
