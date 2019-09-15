using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_47_Exercicios_Membros_Estaticos
{
    class Program
    {
        public static NumberStyles CurrenInfo { get; private set; }

        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                  
            Console.Write("Quantos dólares você vai comprar?");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Valor a ser pago em reais: " +  ConversorDeMoeda.ConversaoMoeda(cotacao, dolares).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
