using System;
using System.Globalization;

namespace POO_16_11_Exerccicio1
{
	public class ContaJuridica : Conta
	{
		//Declarações das variáveis e uso do encapsulamento
		public double _emprestimoLimite;
		public double saldoTotal()
		{
			return GetSaldo() + GetEmprestimoLimite();
		}
		//Criação do construtor com parâmetros utilizando o da Classe Conta
		public ContaJuridica(string nome) : base(nome)
		{
			SetEmprestimoLimite();
		}

		#region Get&Set&Update EmprestimoLimite

		//GET
		public double GetEmprestimoLimite()
		{
			return _emprestimoLimite;
		}

		//SET
		public void SetEmprestimoLimite()
		{
			//Critérios para entrada de dados
			if (GetSaldo() <= 100 && GetSaldo() >= 0)
			{
				_emprestimoLimite += 100;
			}
			else
			{
				_emprestimoLimite = GetSaldo() * 5;
			}
		}

		//UPDATE
		public void UpdateEmprestimoLimite()
		{
			//Em caso de solicitar aumento do valor do emprestimo, valida se é possível
			if (saldoTotal() - GetEmprestimoLimite() >= 0)
			{
				SetEmprestimoLimite();
				Console.WriteLine("Valor do Emprestimo Atualizado!");
			}
			else
			{
				Console.WriteLine("Conta negativa, não é possível aumentar o valor de emprestimo");
			}
		}
		#endregion

		public void Emprestimo(double saqueEmprestimo)
		{
			if (saldoTotal() > 0)
			{
				_emprestimoLimite -= saqueEmprestimo;
			}
		}
		public override string ToString()
		{
			return "Dados da conta jurídica: \nConta:" + GetID()
				+ "\nTitular: " + GetNome()
				+ "\nSaldo: R$" + GetSaldo().ToString("F2", CultureInfo.InvariantCulture)
				+ "\nEmpréstimo Limite: R$" + GetEmprestimoLimite().ToString("F2", CultureInfo.InvariantCulture)
				+ "\nSaldo Total: R$" + saldoTotal().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}