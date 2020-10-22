using System;
using System.Globalization;

namespace POO_21_09
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
            
            Produto p = new Produto(nome, preco, quantidade);
            #endregion

            //Exibe Dados do Produto Cadastrado
            Console.WriteLine("---Dados--- \n" + p);

            //Chama Método para adicionar estoque e exibe os dados atualizados
            p.AdicionarProduto(p);
            Console.WriteLine("---Dados Atualizados--- \n" + p);

            //Chama Método para remoção de estoque e exibe os dados atualizados
            p.RemoverProduto(p);
            Console.WriteLine("---Dados Atualizados--- \n" + p);
        }
    }
}
