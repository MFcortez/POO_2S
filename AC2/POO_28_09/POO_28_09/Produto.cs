using System;
using System.Globalization;

namespace POO_28_09
{
	public class Produto
	{
		private string _nome;
		private double _preco;
		private int _quantidade;



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
		#region Get&Set Preço

		//GET
		public double GetPreco()
		{
			return _preco;
		}

		//SET
		public void SetPreco(double preco)
		{
			//Critérios para entrada de dados
			if (preco >= 0)
			{
				_preco = preco;
			}
		}
		#endregion
		#region Get&Set Quantidade

		//GET
		public int GetQuantidade()
		{
			return _quantidade;
		}

		//SET
		public void SetQuantidade(int quantidade)
		{
			//Critérios para entrada de dados
			if (quantidade >= 0)
			{
				_quantidade = quantidade;
			}
		}
		#endregion

		public double ValorTotalEstoque()
		{
			double val = _quantidade * _preco;
			return val;
		}

		public void AdicionarProduto(Produto var)
		{
			// Adiciona produtos ao estoque estoque
			Console.Write("Quantos produtos gostaria de adicionar ao estoque? ");
			var._quantidade += Int32.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		}

		public void RemoverProduto(Produto var)
		{
			// Adiciona produtos ao estoque estoque
			Console.Write("Quantos produtos gostaria de remover do estoque? ");
			var._quantidade -= Int32.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		}

		public override string ToString()
		{
			return "Nome: " + _nome
				+ "\nPreço: R$ " + _preco.ToString("F2", CultureInfo.InvariantCulture)
				+ "\nQuantidade: " + _quantidade + " unidades"
				+ "\nTotal: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
