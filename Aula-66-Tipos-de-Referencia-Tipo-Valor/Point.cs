using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_66_Tipos_de_Referencia_Tipo_Valor
{
    struct Point
    {

        public double x;
        public double y;


        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }

    }
}
