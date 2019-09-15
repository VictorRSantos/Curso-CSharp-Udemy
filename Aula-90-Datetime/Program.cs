using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_90_Datetime
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = DateTime.Now;
            Console.WriteLine("Data e hora Padrão: " + d1);
            Console.WriteLine("Quantidades de Ticks: " + d1.Ticks);

            Console.WriteLine("");
            //Instanciação
            DateTime d2 = new DateTime(2018, 11, 25);
            Console.WriteLine(d2);

            Console.WriteLine("");
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03);
            Console.WriteLine(d3);


            Console.WriteLine("");
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
            Console.WriteLine(d4);


            Console.WriteLine("");
            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            Console.WriteLine("");
            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);

            Console.WriteLine("");
            DateTime d7 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d7);


            Console.WriteLine("");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d8);


            Console.WriteLine("");
            DateTime d9 = DateTime.Parse("15/08/2000");
            Console.WriteLine(d9);

            Console.WriteLine("");
            DateTime d10 = DateTime.Parse("15/08/2000 12:00:59");
            Console.WriteLine(d10);


            Console.WriteLine("");
            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);


            Console.WriteLine("");
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:10:58", "dd/mm/yyyy HH:mm:ss ", CultureInfo.InvariantCulture);
            Console.WriteLine(d12);


        }
    }
}

