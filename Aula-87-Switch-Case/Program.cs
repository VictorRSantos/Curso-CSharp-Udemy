using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_87_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());

            string day;

            switch (x)
            {

                case 1:
                    day = "Sunday - Domingo";
                    break;
                case 2:
                    day = "Monday - Segunda-Feira";
                    break;
                case 3:
                    day = "Tuesday - Terça-Feira";
                    break;
                case 4:
                    day = "Wednesday - Quarta-Feira";
                    break;
                case 5:
                    day = "Thursday - Quinta-Feira";
                    break;
                case 6:
                    day = "Friday - Sexta-Feira";
                    break;
                case 7:
                    day = "Saturday - Sabádo";
                    break;

                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine(day);


        }
    }
}
