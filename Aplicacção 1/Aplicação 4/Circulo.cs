using System;
namespace Aplicação_4
{
	public class Circulo
	{
        private double raio;
        private double pi = 3.14;

        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public double Area()
        {
            return pi * Math.Pow(raio, 2);
        }

        public double Comprimento()
        {
            return 2 * pi * raio;
        }
    }
}
}

