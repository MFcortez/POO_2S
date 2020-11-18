using System;
using System.Collections.Generic;
using System.Globalization;

public class Funcionario
{
	//Variáveis
	public string Id;
	string Nome;
	double Salario;

	#region Construtor de ID da conta
	private string ConstructID()
	{
		string _generated;
		Random num = new Random();

		_generated = num.Next(10).ToString();
		for (int i = 0; i < 2; i++)
		{
			_generated = _generated + num.Next(10).ToString();
		}

		return _generated;
	}

	#endregion

	//Construtor
	public Funcionario(string nome, double salario)
	{
		Id = ConstructID();
		Nome = nome;
		Salario = salario;
	}

	//Aumentar Salário
	public void aumentarSalario(double porcetagem)
	{
		porcetagem /= 100;
		porcetagem += 1;
		Salario *= porcetagem;
	}

	//ToString
	public override string ToString()
	{
		return "Dados do Funcionário: \nID:" + Id
			+ "\nNOME: " + Nome
			+ "\nSALÁRIO: R$" + Salario.ToString("F2", CultureInfo.InvariantCulture);
	}
}
