using System;
using System.Globalization;

namespace POO_16_11_Exerccicio1
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
            ContaPoupanca conta = new ContaPoupanca(nome);
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

            //Fazendo atualização de valor de saldo
            Console.WriteLine("Fazendo depósito de valor rendido em juros da poupança!");
            Console.ReadKey();

            conta.atualizacaoSaldo();

            //Mostrando os dados da conta
            Console.WriteLine(conta.ToString());

            //Fazendo o Saque, caso não haja saldo suficiente faz empréstimo
            Console.WriteLine("Insira um valor para sacar: ");
            valor2 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (conta.GetSaldo() >= valor2)
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