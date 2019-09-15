using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_82_Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);


            ////Remove Elemento do Conjunto
            //B.Remove(4);


            //Console.Write("Digite um valor interiro: ");
            //int n = int.Parse(Console.ReadLine());

            ////Contains verifica se tem o mesmo número dentro do Conjunto
            //if (B.Contains(n))
            //{
            //    Console.WriteLine($"{n} pertence ao conjunto B");

            //}
            //else
            //{
            //    Console.WriteLine($"{n} não pertence ao conjunto B");

            //}


            //Verificar a diferença entre conjuntos
            //// Vai no conjunto A e remove deles todo mundo que pertence ao conjunto B
            //A.ExceptWith(B);


            //União entre o conjunto A e B
            //A.UnionWith(B);


            //Intersecção 
            //A.IntersectWith(B);


            foreach (int x in A)
            {
                Console.WriteLine(x);

            }


         
           





            Console.ReadLine();

        }
    }
}
