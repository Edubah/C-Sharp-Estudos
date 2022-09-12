﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Propriedades
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public string Nome //Propriedade definindo os métodos get e set
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) //"nome" não pode ser usado porque é o parâmetro de entrada do método SET e esta propriedade não tem o parâmetro de entrada
                {
                    _nome = value; //Value é o mesmo que usar o parâmetro de entrada do método
                }
            }
        }
        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        /* Não serão mais necessários
        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
        */

        public double Preco
        {
            get { return _preco; }
        }

        /*
        public double GetPreco()
        {
            return _preco;
        }

        */

        public int Quantidade
        {
            get { return _quantidade; }
        }

        /*
        public int GetQuantidade()
        {
            return _quantidade;
        }

        */


        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
    
