using System;
using System.Globalization;

namespace POO_16_11_Exerccicio1
{
	public class ContaPoupanca : Conta
	{
		double taxaJuros;

		public ContaPoupanca(string nome) : base(nome)
		{
			taxaJuros = 0.002;
		}

		public void atualizacaoSaldo()
		{
			Deposito(GetSaldo() * taxaJuros); 
		}

		public sealed override void Saque(double valor)
		{
			base._saldo -= valor;
		}
	}
}