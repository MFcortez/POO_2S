using System;

namespace POO_02_11___Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definindo número de linhas e colunas
            Console.WriteLine("Defina o número de linhas que terá a matriz: ");
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Defina o número de colunas que terá a matriz: ");
            int n = Int32.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            //Leitura de entradas da matriz
            for (int i = 0; i < m; i++)
            {
                for (int y = 0; y < n; y++)
                {
                    Console.WriteLine("Entre com os valores da " + (i + 1) + "ª linha e " + (y + 1) + "ª coluna!");
                    mat[i, y] = Int32.Parse(Console.ReadLine());
                }
            }

            //Entrada do número a ser comparado e escrevendo resultado da pesuisa (caso o número não exista na matriz, os resultados retornarão vazios)
            int analise;

            Console.Write("Número pertencente à matriz: ");
            analise = Int32.Parse(Console.ReadLine());

            //Escrita da pesquisa
            for (int i = 0; i < m; i++)
            {
                for (int y = 0; y < n; y++)
                {
                    //Variáveis que representarão as próximas e anteriores linhas e colunas
                    int fm = i + 1, fn = y + 1, pm = i - 1, pn = y - 1;
                    //Validação
                    if (mat[i, y] == analise)//Verifica se  o número é igual ao pesquisado
                    {
                        Console.Write("||   " + mat[i, y] + "   ||");
                    }
                    else if (fn < n && mat[i, fn] == analise)//Verifica se o número pesquisado está na próxima coluna
                    {
                        Console.Write("||   " + mat[i, y] + "   ||");
                    }
                    else if (pn >= 0 && mat[i, pn] == analise)//Verifica se o número pesquisado está na coluna anterior
                    {
                        Console.Write("||   " + mat[i, y] + "   ||");
                    }
                    else if (fm < m && mat[fm, y] == analise)//Verifica se o número pesquisado está na próxima linha
                    {
                        Console.Write("||   " + mat[i, y] + "   ||");
                    }
                    else if (pm >= 0 && mat[pm, y] == analise)//Verifica se o número pesquisado está na coluna anterior
                    {
                        Console.Write("||   " + mat[i, y] + "   ||");
                    }
                    else//Escreve um valo nulo caso nenhum dos filtros tenham retornado true
                    { 
                        Console.Write("||       ||");
                    }
                }
                Console.WriteLine("");//Pula uma linha
            }

        }
    }
}
