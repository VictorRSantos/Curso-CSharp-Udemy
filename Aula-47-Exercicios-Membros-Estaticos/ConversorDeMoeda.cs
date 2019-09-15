using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_47_Exercicios_Membros_Estaticos
{
    class ConversorDeMoeda
    {
        
       

        public static double ConversaoMoeda(double c, double d)
        {

            double calc = c * d;

            double conversao = calc  + ((calc * 6.0) / 100);

            return conversao;

        }



    }
}
