using System;
using System.Globalization;
using System.Collections.Generic;

namespace POO_23_11___Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de produtos: ");
            int n = Int32.Parse(Console.ReadLine());

            List<Produto> produtos = new List<Produto>(n);

            #region Cadastro de Produtos
            for (int i = 0; i<n; i++)
            {
                Console.Write("\nPRODUTO #" + (i + 1) 
                    + "\nComum, Usado ou Importado? (C/U/I): ");

                string choice = Console.ReadLine();

                while (choice != "C" && choice != "U" && choice != "I")
                {
                    Console.Write("Insira uma opção válida!!! (C/U/I): ");
                    choice = Console.ReadLine();
                }

                Console.Write("Insira o nome do produto: ");
                string nome = Console.ReadLine();

                Console.Write("Insira o preço do produto: ");
                double preco = Double.Parse(Console.ReadLine());

                //Valida se o produto é Comum, Importado ou Usado
                if (choice == "U")
                {
                    Console.Write("Insira a data de fabricação do produto: ");
                    DateTime fabricacao = DateTime.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoUsado(nome, preco, fabricacao));
                }
                else if(choice == "I")
                {
                    Console.Write("Insira a taxa do produto: ");
                    double taxa = Double.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoImportado(nome, preco, taxa));
                }
                else if(choice == "C")
                {
                    produtos.Add(new Produto(nome, preco));
                }

            }
            #endregion


            foreach (Produto obj in produtos)
            {
                Console.WriteLine(obj.precoTag());
            }

            Console.ReadKey();

        }
    }

}

