using System;

namespace POO_19_10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Construtor do hotel
            Quarto[] hotel = new Quarto[10];
            for (int i = 0; i< hotel.Length; i++)
            {
                hotel[i] = new Quarto(false, i, "", "");
            }
            #endregion

            Console.Write("Quantos hospédes farão Check-in: ");
            int x = Int32.Parse(Console.ReadLine());

            #region Estrutura de Input
            for (int i = 0; i < x; i++)
            {
                #region Dados do hospede
                Console.WriteLine("HOSPEDE " + (i + 1));
                Console.WriteLine("--------------------------------");
                Console.Write("Número do Quarto (0-9): ");
                int num = Int32.Parse(Console.ReadLine());
                Console.Write("Nome do hospede: ");
                string name = Console.ReadLine();
                Console.Write("Email do hospede: ");
                string email = Console.ReadLine();
                #endregion

                //Valida se o quarto existe e se está ocupado
                while(0 > num || num > 9 || hotel[num]._ocp == true)
                {
                    Console.Write("Insira um número de quarto válido (0-9): ");
                    num = Int32.Parse(Console.ReadLine());
                }

                //Inputa os dados
                hotel[num] = new Quarto(true, num, name, email);
            }
            #endregion

            #region Estrutura de Display
            foreach(Quarto qrt in hotel)
            {
                Console.WriteLine("\nQUARTO " + qrt._num +
                    "\n-----------------------" +
                    "\n NOME: " + qrt._name +
                    "\n EMAIL: " + qrt._email +
                    "\n---------END-----------"
                    );
            }
            #endregion

            Console.ReadKey();
        }
    }
}
