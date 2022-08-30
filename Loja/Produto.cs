using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Loja
{
     class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()//Obrigado a dar retorno pelo fato que não é ->void
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;//aqui esta fazendo o calculo de quantidade += soma Quantidade
        }
        public override string ToString()
        {
            return Nome 
                + ", $" 
                + Preco.ToString("F2",CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                +" UNIDADES , Total: $"
                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}
