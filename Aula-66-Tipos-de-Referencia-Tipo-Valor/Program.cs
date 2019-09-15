using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_66_Tipos_de_Referencia_Tipo_Valor
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p;

            p.x = 10;
            p.y = 20;

            Console.WriteLine(p);

            p = new Point();

            Console.WriteLine(p);

        }
    }
}
