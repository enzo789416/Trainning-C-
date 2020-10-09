using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Segundo
{
    class Produto4
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto4()
        {
            
            
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome.Length > 1 && nome != null) //validacoes podem ser feitas aqui
            {
                _nome = nome;
            }
            
        }

        //public double GetPreco()
        //{
        //    return _preco;
        //}

        public double GetPreco() => _preco;

        //public double GetQuantidade()
        //{
        //    return _quantidade;
        //}

        public double GetQuantidade() => _quantidade;

        public double ValorTotalEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProduto(int x)
        {
            _quantidade += x;
        }

        public void RemoverProduto(int y)
        {
            _quantidade -= y;
        }

        public override string ToString()
        {
            return _nome + ", $" + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidades, Total: $" + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
