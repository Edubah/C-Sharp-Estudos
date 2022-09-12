using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Auto_Propiedades
{
    class Produto
    {

        // Ordem Sugerida para implementar membros de uma classe:
        //1º - Produto Privativo
        private string _nome;
        //2º - Propriedades auto implementadas 
        public double Preco { get; private set; }   
        public int Quantidade { get; private set; } 

        //3º - Métodos Construtores
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //4º - Propriedades Customizadas 
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

        //5º - Outros Métodos 
        public double ValorTotalEmEstoque
        {
            get { return Preco * Quantidade; }
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
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
