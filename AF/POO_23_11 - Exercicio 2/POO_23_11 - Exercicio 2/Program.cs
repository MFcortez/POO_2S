using System;
using System.Collections.Generic;
using POOEnums;

namespace POO_23_11___Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de Formas: ");
            int n = Int32.Parse(Console.ReadLine());

            List<Forma> formas = new List<Forma>(n);

            #region Cadastro de Formas
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nFORMA #" + (i + 1)
                    + "\nRetangulo ou Circulo? (R/C): ");

                string choice = Console.ReadLine();

                while (choice != "C" && choice != "R")
                {
                    Console.Write("Insira uma opção válida!!! (R/C): ");
                    choice = Console.ReadLine();
                }

                Console.Write("Insira a cor da Forma (Preto/Azul/Vermelho): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());


                //Valida se a forma é um Retangulo ou um Circulo
                if (choice == "R")
                {
                    Console.Write("Insira a largura do Retangulo: ");
                    double largura = Double.Parse(Console.ReadLine());
                    Console.Write("Insira a altura do Retangulo: ");
                    double altura = Double.Parse(Console.ReadLine());
                    formas.Add(new Retangulo(largura,altura,color));
                }
                else if (choice == "C")
                {
                    Console.Write("Insira o raio do Círculo: ");
                    double raio = Double.Parse(Console.ReadLine());
                    formas.Add(new Circulo(raio, color));
                }

            }
            #endregion


            foreach (Forma obj in formas)
            {
                Console.WriteLine(obj.Area());
            }

            Console.ReadKey();
        }
    }
}
