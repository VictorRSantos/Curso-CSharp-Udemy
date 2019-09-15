using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_60_Exercicios_de_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {

            Banco banco = new Banco();

            Console.Write("Entre com o número da conta: ");
            banco.Conta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            banco.Titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (S / N)? ");
            string confirma = Console.ReadLine();
                     

            banco.ValorSaldo(confirma, banco.Deposito);
            Console.WriteLine(banco);
            
            Console.WriteLine("");
            Console.Write("Entre com um valor para depósito: ");
            banco.Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            banco.ValorDeposito(banco.Deposito);
            Console.WriteLine(banco);

            Console.WriteLine("");

            Console.Write("Entre com um valor para Saque: ");
            banco.Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            banco.ValorSaque(banco.Saque);
            Console.WriteLine(banco);







        }
    }
}
