namespace Aula_79_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarar Matriz - com 2 linhas e 3 colunas
            double[,] mat = new double[2, 3];

            System.Console.WriteLine( mat.Length);//Quantos elementos a matriz tem no local

            System.Console.WriteLine(mat.Rank);//Quantidade de linhas

            System.Console.WriteLine(mat.GetLength(0));//pega a primeira posição dimensão da matriz

            System.Console.WriteLine(mat.GetLength(1));//pega a Segunda posição dimensão da matriz






        }
    }
}
