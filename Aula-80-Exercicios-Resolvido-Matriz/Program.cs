using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_80_Exercicios_Resolvido_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número:");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];


            //Percorre as linhas
            for (int i = 0; i < n; i++)
            {

                string[] values = Console.ReadLine().Split(' ');

                //Percorre as colunas
                for (int j = 0; j < n; j++)
                {

                    mat[i,j] = int.Parse(values[j]);                
                    

                }

            }



        }
    }
}
