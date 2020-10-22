using System;
using System.Globalization;

namespace POO_21_09
{
	public class Produto
	{
		public string _nome;
		public double _preco;
		public int _quantidade;

		public Produto (string nome, double preco, int quantidade) 
		{
			_nome = nome; 
			_preco = preco; 
			_quantidade = quantidade; 
		}

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
