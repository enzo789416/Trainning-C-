using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Segundo
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEstoque()
        {
            return preco * quantidade;
        }

        public void AdicionarProduto(int x)
        {
             quantidade += x;
        }

        public void RemoverProduto(int y)
        {
            quantidade -= y;
        }

        public override string ToString()
        {
            return nome + ", $" + preco.ToString("F2",CultureInfo.InvariantCulture) + ", " + quantidade + " unidades, Total: $" + ValorTotalEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
