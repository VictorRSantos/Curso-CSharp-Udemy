using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_71_Exercicio_Vetores
{
    class Pensao
    {


        public string Name { get; set; }
        public string Email { get; set; }

        public Pensao(string nome, string email)
        {
            Name = nome;
            Email = email;

        }


        public override string ToString()
        {
            return Name + ", " + Email;
        }


    }
}
