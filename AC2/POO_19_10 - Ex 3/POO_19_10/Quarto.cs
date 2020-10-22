using System;

namespace POO_19_10
{
	public class Quarto
	{
		public int _num;
		public string _name;
		public string _email;
		public bool _ocp;
		public Quarto(bool ocp, int num, string name, string email)
		{
			_ocp = ocp; 
			_num = num;
			_name = name;
			_email = email;
		}
	}
}
