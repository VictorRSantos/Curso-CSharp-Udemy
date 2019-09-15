using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_60_Exercicios_de_Fixacao
{
    class Banco
    {

       

        public int Conta { get; private set; }

        public string Titular { get; set; }
      
        public double Saldo { get; private set; }

        public Banco(){}


        public double ValorSaldo(string confirma, double valorDeposito)
        {
               

            if (confirma == "s" | confirma == "S")
            {

                
                Console.Write("Entre com o valor de depósito inicial: ");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("");
                Console.WriteLine("Dados da conta:");

                return Saldo += valorDeposito;

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Dados da conta:");

                return Saldo += valorDeposito;

            }



        }

        public double ValorDeposito(double deposito)
        {

            if (deposito > 0)
            {

                Console.WriteLine("Dados da conta atualizados:");
                return  Saldo +=  deposito;

            }
            else
            {
                Console.WriteLine("Dados da conta atualizados:");
                return Saldo = deposito;

            }

           
        }




        public double ValorSaque(double saque)
        {

            if (saque <= Saldo)
            {
                Console.WriteLine("Dados da conta atualizados:");
                return Saldo = Saldo - saque - 5;

            }
            else
            {
                Console.WriteLine("Dados da conta atualizados:");
                return Saldo = Saldo - saque - 5;
            }

        }





        public override string ToString()
        {
            return "Conta " + Conta + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }




    }
}
