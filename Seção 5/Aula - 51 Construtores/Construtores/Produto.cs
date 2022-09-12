using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Construtores
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Geralmente o método constutor é criado após os atibutos/variáveis
        public Produto(string nome, double preco, int quantidade) // Na hora de instanciar o produto, será obrigatório informar as informações dele quando for criado
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            //Atribuído cada variaável com o método contrutor
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
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidade, Total: $ "
                + ValorTotalEmEstoque().ToString("F1", CultureInfo.InvariantCulture);

        }
    }
}
