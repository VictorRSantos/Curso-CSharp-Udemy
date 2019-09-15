using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_45_Exercicio_03
{
    class Aluno
    {

        public string Nome;

        public double N1;

        public double N2;

        public double N3;


        public double MediaAluno()
        {

            double media = N1 + N2 + N3;

            double resultado = media / 3;

            if (resultado >= 60)
            {

                 Console.WriteLine($"NOTA FINAL =  {resultado.ToString("F2", CultureInfo.InvariantCulture)}\nAPROVADO");
                
            }
            else
            {

                Console.WriteLine($"NOTA FINAL =  {resultado.ToString("F2", CultureInfo.InvariantCulture)}\nREPROVADO\nFALTARAM {resultado - 60} PONTOS");
                
            }

            return resultado;
           
        }


    }
}
