using System;
using System.Globalization;
using System.Linq;


namespace POO_19_10
{
    class Program
    {
        static void Main(string[] args)
        {

            //Construção do Vetor
            Console.Write("Insira quantos consoles serão cadastrados: ");
            int x = Int32.Parse(Console.ReadLine());

            Produto[] vector = new Produto[x];

            //Declaração de varíavel para uso futuro
            double[] med = new double[x];

            #region Estrutura de Input
            for (int i = 0; i < vector.Length; i++)
            {
                #region Dados do Console
                Console.WriteLine("\n--------------------------------");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("\n--------------------------------");

                //Atribuição dos preços no Array de média
                vector[i] = new Produto (nome, preco);
                med[i] = vector[i]._preco;
                #endregion

            }
            #endregion

            #region Estrutura de Display

            Console.WriteLine("Média dos preços: " + med.Average());

            #endregion

            Console.ReadKey();
        }
    }
}
