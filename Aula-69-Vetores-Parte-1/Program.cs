using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_69_Vetores_Parte_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < vect.Length; i++)
            {
                Console.Write($"{i + 1}º Altura: ");
                vect[i] = double.Parse(Console.ReadLine());

            }


            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("Altura media = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
