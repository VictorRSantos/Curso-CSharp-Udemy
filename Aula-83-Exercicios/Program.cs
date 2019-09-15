using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_83_Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            Console.Write("O Curso 'A' possui quantos alunos? ");
            int a = int.Parse(Console.ReadLine());

            int contador = 0;


            while (contador < a)
            {


                Console.Write($"Digite os codigos dos alunos do curso A: = ");
                int codigoAluno = int.Parse(Console.ReadLine());

                cursoA.Add(codigoAluno);


                contador++;

            }

            contador = 0;

            Console.WriteLine(" ");

            Console.Write("O Curso 'B' possui quantos alunos? ");
            int b = int.Parse(Console.ReadLine());

            while (contador < b)
            {
                Console.Write($"Digite os códigos dos alunos do Curso B: = ");
                int codigoCurso = int.Parse(Console.ReadLine());

                cursoB.Add(codigoCurso);

                contador++;

            }

            Console.WriteLine("");
            contador = 0;

            Console.Write("O curso 'C' possui quantos alunos? ");
            int c = int.Parse(Console.ReadLine());

            while (contador < c)
            {
                Console.Write($"Digite os códigos dos alunos do Curso C: = ");
                int codigoCurso = int.Parse(Console.ReadLine());

                cursoC.Add(codigoCurso);

                contador++;
            }

            HashSet<int> novo = new HashSet<int>();
            novo.UnionWith(cursoA);
            novo.UnionWith(cursoB);
            novo.UnionWith(cursoC);

            Console.WriteLine($"Total de alunos: {novo.Count}");


                                                  
        }
    }
}
