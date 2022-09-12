using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Encapsulamento
{
    class Produto
    {
        private string _nome; //Private previne que o atributo/variável não seja utilizado por outras classes
        private double _preco;
        private int _quantidade;
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string GetNome() //QUando é necessário OBTER o valor de um produto, é utilizado o método GET.
        {
            return _nome;
        }
        public void SetNome(string nome) //Quando é necessário definir ou alterar o valor é utilizado o método SET.
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }
    }
}