using System;
using System.Globalization;

namespace POO_09_11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cadastro da Conta com Construtor
            Console.WriteLine("Entre com os dados da conta:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            //Set dos produtos dentro da classe
            ContaJuridica conta = new ContaJuridica(nome);
            #endregion

            //Opção de depósito inicial e validação
            Console.WriteLine(conta.GetNome() + " deseja fazer um depósito inicial na conta " + conta.GetID() + "? (S/N)");
            string choice = Console.ReadLine();

            while (choice != "S" && choice != "N")
            {
                Console.WriteLine("Insira uma opção válida!!! (S/N)");
                choice = Console.ReadLine();
            }

            //Fazendo o Depósito
            if (choice == "S")
            {
                Console.WriteLine("Insira o valor do depósito inicial: ");
                double valor = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(valor);
            }

            //Mostrando os dados da conta
            Console.WriteLine(conta.ToString());

            //Fazendo o segundo depósito
            Console.WriteLine("Insira um valor para depositar: ");
            double valor2 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor2);

            //Mostrando os dados da conta
            Console.WriteLine(conta.ToString());

            //Fazendo atualização de valor de empréstimo
            Console.WriteLine("Deseja liberar um valor maior para empréstimo? (S/N)");
            string att = Console.ReadLine();

            if(att == "S")
            {
                conta.UpdateEmprestimoLimite();
            }
            else
            {
                Console.WriteLine("Não foi possível atualizar!");
            }

            //Mostrando os dados da conta
            Console.WriteLine(conta.ToString());

            //Fazendo o Saque, caso não haja saldo suficiente faz empréstimo
            Console.WriteLine("Insira um valor para sacar: ");
            valor2 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if(conta.GetSaldo() < valor2 && conta.saldoTotal() > valor2)
            {
                Console.WriteLine("Ao fazer este saque, você está sacando do emprestimo!");
                if(conta.GetEmprestimoLimite() < valor2)//Valida se o valor do empréstimo cobre o saque, e caso cubra completa com o valor em conta
                {
                    double valor3 = valor2 - conta.GetSaldo();
                    valor2 -= conta.GetEmprestimoLimite();
                    conta.Emprestimo(valor3);
                    conta.Saque(valor2);
                }
                else
                {
                    conta.Emprestimo(valor2);
                }
            }
            else if(conta.GetSaldo() >= valor2)
            {
                conta.Saque(valor2);
            }
            else
            {
                Console.WriteLine("Não foi possível fazer o saque");
            }


            //Mostrando os dados da conta
            Console.WriteLine(conta.ToString());


        }
    }
}
