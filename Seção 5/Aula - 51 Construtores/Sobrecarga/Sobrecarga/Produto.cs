using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Sobrecarga
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtor
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto() {
            Quantidade = 10;
        } //Método Construtor Padrão

        public Produto(string nome, double preco) : this() //Método de sobrecarga
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; //Não há a necessidade de colocar está parte, pois já é atribuído o valor 0 para a variável.
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
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
