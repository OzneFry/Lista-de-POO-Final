using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPOO.Models
{
    public class Produto
    {
        private int _quantidadeTotal;

        public string Nome { get; set; }
        public double Preco { get; set; }

        public int Quantidade
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantidade não pode ser negativa");
                _quantidade = value;
            }
        }
        private int _quantidade;

        public int QuantidadeTotal => _quantidadeTotal;

        public void AdicionarEstoque()
        {
            _quantidadeTotal += _quantidade;
        }

        public void RemoverEstoque(int qtde)
        {
            if (qtde > _quantidadeTotal)
                throw new ArgumentException("Estoque insuficiente");

            _quantidadeTotal -= qtde;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * _quantidadeTotal;
        }
    }
}