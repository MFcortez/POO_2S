using System;
using System.Globalization;
using System.Linq;

namespace POO_12_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de para uso futuro
            double media;

            //Tamanho do array
            Console.Write("Número de pessoas: ");
            int a = Int32.Parse(Console.ReadLine());

            //Declaração do valor da altura (Vetor)
            double [] alt = new double [a];

            //Leitura da altura de -a- pessoas
            for(int i = 0;  i < a; i++)
            {
                Console.Write("Altura da " + (i + 1) + "ª pessoa: ");
                alt[i] = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //Calculo da média
            media = alt.Average();

            //Apresentação de valores
            Console.WriteLine("A média de altura das pessoas inseridas é: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
