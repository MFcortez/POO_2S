using System;
using System.Globalization;

namespace POO_16_112
{
	//Classe Funcionário Terceirizado
	public class FuncionarioTerceirizado:Funcionario
	{
		double Adicional;

		//Construtor
		public FuncionarioTerceirizado(string nome, int horas, double valorHora, double adicional) : base(nome,horas,valorHora)
		{
			Adicional = adicional;
		}

		//Override em método pagamento
		public override double Pagamento()
        {
			return base.Pagamento() + (Adicional * 1.10);
        }
	}
}
