﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_89_Funcoes_Interessantes_para_Strings
{
    class Program
    {
        static void Main(string[] args)
        {


            string original = "abcde FGHIJ ABC abc DEFG ";

            //Tudo maiusculo
            string s1 = original.ToUpper();
            //Tudo Minusculo
            string s2 = original.ToLower();
            //Trim - apaga espaço em branco da string no inicio e final
            string s3 = original.Trim();
            //Procurar a posição dos caracteres  dentro da string

            int n1 = original.IndexOf("bc");
            //Procurar a ultima posição dos caracteress dentro da string
            int n2 = original.LastIndexOf("bc");

            //Recortar uma string
            string s4 = original.Substring(3);
            //Recorta da posição 3 - 5 caracteres
            string s5 = original.Substring(3,5);
            //Substituir uma parte da string por outra - Substitui todos caracteres 'a' por 'x'
            string s6 = original.Replace('a','x');
            //replace com string
            string s7 = original.Replace("abc", "xy");

            //Verificar se a string está vazia
            bool b1 = String.IsNullOrEmpty(original);
            //Verificar se a string é nula ou é um monte de espaço em branco
            bool b2 = String.IsNullOrWhiteSpace(original);


            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc') -" + n1);
            Console.WriteLine("LastIndexOf('bc') -" + n2);
            Console.WriteLine("Substring(3) -" + s4);
            Console.WriteLine("Substring(3,5) -" + s5);
            Console.WriteLine("Replace(a, x) -" + s6);
            Console.WriteLine("Replace(abc, xy) -" + s7);
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);






        }
    }
}
