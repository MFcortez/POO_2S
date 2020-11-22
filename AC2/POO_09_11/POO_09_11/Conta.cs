using System;
using System.Globalization;

namespace POO_09_11
{
	public class Conta
	{
		private string _id;
		private string _nome;
		private double _saldo;

		#region Construtor de ID da conta
		private string ConstructID()
		{
			string _generated;
			Random num = new Random();

			_generated = num.Next(10).ToString();
			for (int i = 0; i < 3; i++)
			{
				_generated = _generated + num.Next(10).ToString();
			}

			return _generated;
		}

		#endregion

		public Conta(string nome)
		{
			_id = ConstructID();
			_nome = nome;
			_saldo = 0;
		}


		#region Get ID

		//GET
		public string GetID()
		{
			return _id;
		}
		#endregion


		#region Get&Set Nome

		//GET
		public string GetNome()
		{
			return _nome;
		}

		//SET
		public void SetNome(string nome)
		{
			//Critérios para entrada de dados
			if (nome != null && nome.Length > 0)
			{
				_nome = nome;
			}
		}
		#endregion

		#region Get Saldo

		//GET
		public double GetSaldo()
		{
			return _saldo;
		}

		#endregion

		#region Depósito e Saque
		public void Deposito(double valor)
		{
			_saldo += valor;
		}

		public void Saque(double valor)
		{
			_saldo -= (valor + 5);
		}
		#endregion

		public override string ToString()
		{
			return "Dados da conta: \nConta:" + _id
				+ "\nTitular: " + _nome
				+ "\nSaldo: R$" + _saldo.ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
