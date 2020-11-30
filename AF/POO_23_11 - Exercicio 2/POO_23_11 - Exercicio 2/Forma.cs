using System;
using POOEnums;

namespace POO_23_11___Exercicio_2
{
	public abstract class Forma
	{
		public Color Color;
		public Forma(Color color)
		{
			Color = color;
		}

		public abstract double Area();
	}
}
