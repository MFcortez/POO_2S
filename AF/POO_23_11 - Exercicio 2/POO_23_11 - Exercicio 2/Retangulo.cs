using System;
using POOEnums;

namespace POO_23_11___Exercicio_2
{
	public class Retangulo : Forma
	{
		public double Largura, Altura;
		public Retangulo(double largura, double altura, Color color) : base(color)
		{
			Largura = largura;
			Altura = altura;
		}

		public override double Area()
		{
			return Largura * Altura;
		}
	}
}