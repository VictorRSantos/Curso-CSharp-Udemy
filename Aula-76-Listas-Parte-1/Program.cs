using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_76_Listas_Parte_1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();
                
            list.Add("Victor");
            list.Add("ISabel");
            list.Add("Isabelly");
            list.Add("Cachorro");
            list.Insert(2, "Marco");  //Adicionou nome na segunda posição         

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count); //Mostrar tamanho da lista


            string s1 = list.Find(x => x[0] == 'C');
            Console.WriteLine("First 'V':" + s1);


            string s2 = list.FindLast(x => x[0] == 'C');
            Console.WriteLine("Last 'R': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'V');
            Console.WriteLine("First position 'V': " + pos1);


            int pos2 = list.FindLastIndex(x => x[0] == 'C');
            Console.WriteLine("First position 'V': " + pos2);



            List<string> list2 = list.FindAll(x => x.Length == 5);
                        
            Console.WriteLine("----------------------------------");

            foreach (var item in list2)
            {

                Console.WriteLine(item);
            }


       
            list.Remove("Victor");
            Console.WriteLine("-------------------------------------");
            foreach (string item in list2)
            {
                Console.WriteLine(item);

            }

            list.RemoveAll(x => x[0] == 'i');
            Console.WriteLine("-------------------------------------");
            foreach (string item in list2)
            {
                Console.WriteLine(item);

            }


        }
    }
}
