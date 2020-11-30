using System;
using System.Globalization;

namespace POO_23_11___Exercicio_1
{
	public class Produto
	{
		public string Nome;
		public double Preco;
		public virtual string precoTag()
		{
			return Nome + " - R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture);
		}
			   
		public Produto(string nome, double preco)
		{
			Nome = nome;
			Preco = preco;
		}

	}
}