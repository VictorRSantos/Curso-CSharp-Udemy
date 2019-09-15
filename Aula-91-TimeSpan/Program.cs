using System;


namespace Aula_91_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Um objeto TimeSpan internamente armazena uma duração na
             * forma de ticks(100 nanosegundos)
             */


            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

        }
    }
}
