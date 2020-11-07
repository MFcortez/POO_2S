using System;

namespace POO_14_09_20
{
    public class Calculadora
    {
        public static double cambio = 5.24;

        public static double Recalc(double val)
        {
            return val * cambio + ((val * cambio) * 0.6);
        }
    }
}
