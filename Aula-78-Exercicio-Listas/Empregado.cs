using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_78_Exercicio_Listas
{
    public class Empregado
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public double Salario { get; set; }

        public Empregado(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void incrementaSalario(double porcentagem)
        {
            Salario = Salario + (Salario * porcentagem / 100);

        }

        public override string ToString()
        {
            return Id + ", " + Nome  + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
