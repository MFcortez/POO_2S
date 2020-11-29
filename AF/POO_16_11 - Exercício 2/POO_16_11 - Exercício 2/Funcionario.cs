using System;
using System.Globalization;

namespace POO_16_112
{
	//Classe pai, funcionário
	public class Funcionario
	{
		string Nome;
		int Horas;
		double ValorHora;

		//Construtor
		public Funcionario(string nome, int horas, double valorHora)
        {
			Nome = nome;
			Horas = horas;
			ValorHora = valorHora;
        }

		//Método virtual Pagamento
		public virtual double Pagamento()
        {
			return Horas * ValorHora;
        }

		public override string ToString()
		{
			return "\nDados do Funcionário: \nNome:" + Nome
				+ "\nPagamento: " + Pagamento().ToString("F2", CultureInfo.InvariantCulture) 
				+ "\n";
		}
	}
}
