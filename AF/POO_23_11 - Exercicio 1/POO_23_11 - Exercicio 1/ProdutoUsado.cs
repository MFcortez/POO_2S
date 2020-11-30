using System;
using System.Globalization;

namespace POO_23_11___Exercicio_1
{
	public class ProdutoUsado : Produto
	{
		DateTime Fabricacao;

		public override string precoTag()
		{
			return base.precoTag() 
				+ " (Fabricação: " + Fabricacao.ToString("dd/MM/yyyy")
				+ " )";
		}

		public ProdutoUsado(string nome, double preco, DateTime fabricacao) : base(nome, preco)
		{
			Fabricacao = fabricacao;
		}


	}
}
