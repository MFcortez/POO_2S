using System;
using POOEnums;

namespace POO_23_11___Exercicio_2
{
	public class Circulo : Forma
	{
		public double Raio;
		public Circulo(double raio, Color color) : base(color)
		{
			Raio = raio;
		}

		public override double Area()
		{
			return Math.PI * Raio * Raio;
		}
	}
}