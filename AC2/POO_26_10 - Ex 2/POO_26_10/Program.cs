using System;
using System.Collections.Generic;
using System.Globalization;

namespace POO_26_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando número de funcionários e lista
            Console.Write("Quantos funcionários serão registrados: ");
            int n = Int32.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>(n);

            //Cadastrando os funcionários com o construtor
            for(int i = 0; i<n; i++)
            {
                Console.Write("Insira o nome do funcionário: ");
                string nome = Console.ReadLine();
                Console.Write("Insira o salário do funcionário: ");
                double salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(nome, salario));
                Console.WriteLine("FUNCIONÁRIO CADASTRADO \n");
            }

            //Exibindo os Funcionários
            foreach(Funcionario obj in funcionarios)
            {
                Console.WriteLine("\n" + obj.ToString() + "\n");
            }

            //Pergunta ID do funcionário que receberá aumento e valida
            bool valido = false;
            while (valido == false)
            {
                Console.Write("ID do funcionário que terá aumento: ");
                int x = Int32.Parse(Console.ReadLine());
                Console.Write("Insira o valor em porcentagem do aumenta: %");
                double aumento = Double.Parse(Console.ReadLine());


                foreach (Funcionario obj in funcionarios)
                {
                    //Caso o ID seja condizente com algum funcionário, while acaba. Se não, while repete
                    if (obj.Id == x.ToString())
                    {
                        obj.aumentarSalario(aumento);                      
                        valido = true;
                    }
                }
            }

            //Exibe Funcionários
            foreach (Funcionario obj in funcionarios)
            {
                Console.WriteLine("\n" + obj.ToString() + "\n");
            }

        }
    }
}
