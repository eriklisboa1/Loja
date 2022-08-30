using System;
using System.Globalization;
namespace Loja

{
     class Program
    {
        static void Main(string[] args)
        {
            
            Produto p = new Produto();
    


            Console.WriteLine("Entre com os dados do produtos");
            Console.WriteLine("Qual nome do seu produto?");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Qual preço do seu produto");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Qual a quantidade no estoque?");
            p.Quantidade = int.Parse(Console.ReadLine());




            //DADOS ESTOQUE
            Console.WriteLine();
           Console.WriteLine($"DADOS DO PRODUTO {p}");
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado no estoque");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine($"DADOS ATUALIZADOS {p}");//ELE IRA PEGAR OS DADOS ATUALIZADOS
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser retirado");
            int ret = int.Parse(Console.ReadLine());    
            p.RemoverProdutos(ret);
            Console.WriteLine($"DADOS ATUALIZADOS {p}");





            Console.ReadLine();

        }
    }
}
