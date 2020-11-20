using System;

namespace POO_02_11___Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define tamanho da matriz
            Console.Write("N é o número de linha e colunas que terá a matriz, defina N = ");
            int n = Int32.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            //Variável que armazena total de números negativos
            int negativos = 0;

            //Leitura de entradas da matriz
            for(int i =0; i<n; i++)
            {
                for(int y = 0; y < n; y++)
                {
                    Console.WriteLine("Entre com os valores da " + (i + 1) + "ª linha e " + (y + 1) + "ª coluna!");
                    mat[i, y] = Int32.Parse(Console.ReadLine());

                    //Valida se o número é negativo e se for atualiza o total de negativos
                    if(mat[i , y] < 0)
                    {
                        negativos++;
                    }
                }
            }

            //Output das informações solicitadas no exercício
            Console.WriteLine("Diagonal principal:");
            for (int i = 0; i < n; i++)
            {
                for (int y = 0; y < n; y++)
                {
                    if(i == y)
                    {
                        Console.Write(" " + mat[i, y] + " ");
                    } 
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Quantidade de números negativos: " + negativos);

        }
    }
}
