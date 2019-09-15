using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_55_Encapsulamento
{
    class Produto
    {
        //1° Atributo Privativo
        private string _nome;

        //2° Propriedade auto implementada
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        //3° Construtores
        public Produto() { }

        //Construtor com três parametros
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //4° Propiedades Customizadas
        public string Nome
        {

            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;

                }
            }
        }


        //5° Metodos
        public double SetPreco(double preco)
        {
            return Preco = preco;
        }
      


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }


        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }


        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $: "
                + Preco
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }





    }
}
