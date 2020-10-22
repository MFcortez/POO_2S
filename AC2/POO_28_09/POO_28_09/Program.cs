using System;
using System.Globalization;

namespace POO_28_09
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cadastro de Produto com Construtor
            Console.WriteLine("Entre com os dados do produto:"); 
            
            Console.Write("Nome: "); 
            string nome = Console.ReadLine(); 
            
            Console.Write("Preço: "); 
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            
            Console.Write("Quantidade no estoque: "); 
            int quantidade = int.Parse(Console.ReadLine());

            //Set dos produtos dentro da classe
            Produto p = new Produto();
            p.SetNome(nome);
            p.SetPreco(preco);
            p.SetQuantidade(quantidade);
            #endregion

            //Exibe Dados do Produto Cadastrado
            Console.WriteLine("---Dados--- \n" +
                "Nome: " + p.GetNome()
                + "\nPreço: R$ " + p.GetPreco().ToString("F2", CultureInfo.InvariantCulture)
                + "\nQuantidade: " + p.GetQuantidade() + " unidades"
                + "\nTotal: R$ " + p.ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture));

            //Chama Método para adicionar estoque e exibe os dados atualizados
            p.AdicionarProduto(p);
            Console.WriteLine("---Dados Atualizados--- \n" +
                "Nome: " + p.GetNome()
                + "\nPreço: R$ " + p.GetPreco().ToString("F2", CultureInfo.InvariantCulture)
                + "\nQuantidade: " + p.GetQuantidade() + " unidades"
                + "\nTotal: R$ " + p.ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture));

            //Chama Método para remoção de estoque e exibe os dados atualizados
            p.RemoverProduto(p);
            Console.WriteLine("---Dados Atualizados--- \n" + 
                "Nome: " + p.GetNome()
                + "\nPreço: R$ " + p.GetPreco().ToString("F2", CultureInfo.InvariantCulture)
                + "\nQuantidade: " + p.GetQuantidade() + " unidades"
                + "\nTotal: R$ " + p.ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
