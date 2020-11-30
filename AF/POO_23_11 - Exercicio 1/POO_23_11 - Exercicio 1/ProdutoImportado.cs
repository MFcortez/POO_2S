using System;
using System.Globalization;

namespace POO_23_11___Exercicio_1
{
	public class ProdutoImportado : Produto
	{
		double Taxa;
		public double PrecoTotal()
		{
			return base.Preco + Taxa;
		}

		public override string precoTag()
		{
			return Nome + " - R$ "
				+ PrecoTotal().ToString("F2", CultureInfo.InvariantCulture) 
				+ " (R$ " + Taxa.ToString("F2", CultureInfo.InvariantCulture) + ")";
		}

		public ProdutoImportado(string nome, double preco, double taxa) : base(nome, preco)
		{
			Taxa = taxa;
		}


	}
}
