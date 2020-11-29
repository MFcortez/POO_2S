using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace POO_16_112
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebe o número de funcionários a serem cadastrados e cria uma lista com o tamanho informado
            Console.Write("Entre com o número de funcionários: ");
            int n = Int32.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>(n);

            #region Cadastro do Funcionário
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("O funcionário é terceirizado? (S/N)");
                string choice = Console.ReadLine();

                while (choice != "S" && choice != "N")
                {
                    Console.WriteLine("Insira uma opção válida!!! (S/N)");
                    choice = Console.ReadLine();
                }

                Console.Write("Insira o nome do funcionário: ");
                string nome = Console.ReadLine();

                Console.Write("Insira as horas trabalhadas do funcionário: ");
                int horas = Int32.Parse(Console.ReadLine());

                Console.Write("Insira o valor da hora do funcionário: ");
                double valorHora = Double.Parse(Console.ReadLine());

                //Valida se o funcionário é terceirizado e cadastrada com as informações necessárias
                if(choice == "S")
                {
                    Console.Write("Insira o valor do adicional do funcionário: ");
                    double adicional = Double.Parse(Console.ReadLine());
                    funcionarios.Add(new FuncionarioTerceirizado(nome, horas, valorHora, adicional));
                }
                else
                {
                    funcionarios.Add(new Funcionario(nome, horas, valorHora));
                }
            }
            #endregion

            foreach(Funcionario obj in funcionarios)
            {
                Console.WriteLine(obj.ToString());
            }

            Console.ReadKey();
        }
    }
}
