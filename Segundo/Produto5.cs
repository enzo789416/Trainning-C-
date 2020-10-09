using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Segundo
{
    class Produto5
    {
        private string _nome; //por ter regras de set // melhor não usar Auto Properties // ou auto encapsulamento
        public double Preco { get; set; }
        public int Quantidade { get; private set; }

        public Produto5() { }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length > 1 && value != null)
                {
                    _nome = value; //value representa o parametro sendo passado
                }
            }
        }

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int x)
        {
            Quantidade += x;
        }

        public void RemoverProduto(int y)
        {
            Quantidade -= y;
        }

        public override string ToString()
        {
            return _nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $" + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
